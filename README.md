
# World of Warcraft - 3.3.5 - Fishing Bot

This is a light fishing bot application that I picked up from the [WoW Devs](https://github.com/WowDevs/Fishbot-3.3.5) GitHub. Their project was last contributed to 4 years ago from the time of me writing this, and is no longer working. It is my goal to breathe some life back into it, clean it up, refactor, and otherwise make it meet modern and personal code standards. As of this repo's init, the project is working.

Botting is against Blizzard terms and conditions, and will result in your account being banned.

### Technologies --

This project is written wholly in C#, using the [GrayMagic and FASM packages](https://github.com/benjamin-t-wilson/GreyMagic).

### Launch --

In the _WoW-3.3.5-Fishing-Bot\FishBot3.3.5a\bin\Debug_ folder there is an executable file. After opening WoW and logging into your account / character, open this exe as administrator. It will not work without administrator privileges due to the nature of this application's function.

The application intercepts memory created / used by the WoW.exe system process in order to interact directly with the game engine. In addition to requiring admin perms to accomplish, this means it does not hijack the use of your mouse, keyboard, or active window.

### Future Features to Implement

- Look for classes that are agnostic to bot functionality and make them their own project ( ex. WowHook )
- Create repos for each level of the project
- Change excessive use of raw strings into constants
- ~Add a list of all items gatherable via fishing by name and level~ Didn't do level, oops.
- Add an interface to select which items should be removed from the inventory
- Run the inventory check / clean every few fish
- Stop bot when inventory is full
- ~Remove unrelated bot features, there's some buttons with nothing to do with fishing~
