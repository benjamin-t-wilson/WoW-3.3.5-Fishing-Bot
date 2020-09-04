using System;
using System.Text;

namespace FishBot3._3._5a
{
    public class Lua
    {
        private readonly Hook _wowHook;

        public Lua(Hook wowHook)
        {
            _wowHook = wowHook;
        }

        public void DoString(string command)
        {
            if (_wowHook.Installed)
            {
                // Allocate memory
                IntPtr doStringArgCodecave = _wowHook.Memory.AllocateMemory(Encoding.UTF8.GetBytes(command).Length + 1);
                // Write value:
                _wowHook.Memory.WriteBytes(doStringArgCodecave, Encoding.UTF8.GetBytes(command));

                // Write the asm stuff for Lua_DoString
                var asm = new[]
                {
                    "mov eax, " + doStringArgCodecave,
                    "push 0",
                    "push eax",
                    "push eax",
                    //"mov eax, " + ( (uint) Offsets.FrameScript__Execute + _wowHook.Process.BaseOffset()) , // Lua_DoString
                    "mov eax, " + ( (uint) Offsets.FrameScript__Execute ), // Lua_DoString
                    "call eax",
                    "add esp, 0xC",
                    "retn"
                };
                // Inject
                _wowHook.InjectAndExecute(asm);
                // Free memory allocated
                _wowHook.Memory.FreeMemory(doStringArgCodecave);
            }
        }

        internal string GetLocalizedText(string localVar)
        {
            if (_wowHook.Installed)
            {
                IntPtr Lua_GetLocalizedText_Space = _wowHook.Memory.AllocateMemory(Encoding.UTF8.GetBytes(localVar).Length + 1);

                // If you building for MoP or higher then you need to use
                // ClntObjMgrGetActivePlayerObj = Memory.MainModule.BaseAddress + new IntPtr(0xADDRESS);
                // FrameScript__GetLocalizedText = Memory.MainModule.BaseAddress + new IntPtr(0xADDRESS);

                _wowHook.Memory.Write<byte>(Lua_GetLocalizedText_Space, Encoding.UTF8.GetBytes(localVar), false);

                String[] asm = new String[]
                {
                    "call " + (uint) Offsets.ClntObjMgrGetActivePlayerObj,
                    "mov ecx, eax",
                    "push -1",
                    "mov edx, " + Lua_GetLocalizedText_Space + "",
                    "push edx",
                    //"call " + ((uint) Offsets.FrameScript__GetLocalizedText + _wowHook.Process.BaseOffset()) ,
                    "call " + ((uint) Offsets.FrameScript__GetLocalizedText) ,
                    "retn",
                };

                string sResult = Encoding.UTF8.GetString(_wowHook.InjectAndExecute(asm));

                // Free memory allocated
                _wowHook.Memory.FreeMemory(Lua_GetLocalizedText_Space);
                return sResult;
            }
            return "WoW Hook not installed";
        }

        public void CastSpellByName(string spell)
        {
            // Check if spell is ready, if not skip this spell
            DoString("start, duration, enabled = GetSpellCooldown('" + spell + "')");
            var result = GetLocalizedText("duration");

            if (result != "0")
                return;

            DoString(string.Format("CastSpellByName('{0}')", spell));
        }
    }
}