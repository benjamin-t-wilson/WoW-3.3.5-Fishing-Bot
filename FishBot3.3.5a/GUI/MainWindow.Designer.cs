using FishBot3._3._5a.Entities;
using System.Drawing;
using System.Linq;

namespace FishBot3._3._5a
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.cmdFish = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.keptItems = new System.Windows.Forms.ListBox();
            this.dropItems = new System.Windows.Forms.ListBox();
            this.keptToDropButton = new System.Windows.Forms.Button();
            this.dropToKeptButton = new System.Windows.Forms.Button();
            this.keptItemsLabel = new System.Windows.Forms.Label();
            this.dropItemsLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(10, 44);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(492, 518);
            this.LogTextBox.TabIndex = 0;
            this.LogTextBox.Text = "";
            // 
            // cmdFish
            // 
            this.cmdFish.Location = new System.Drawing.Point(265, 6);
            this.cmdFish.Margin = new System.Windows.Forms.Padding(4);
            this.cmdFish.Name = "cmdFish";
            this.cmdFish.Size = new System.Drawing.Size(105, 31);
            this.cmdFish.TabIndex = 1;
            this.cmdFish.Text = "Start Fishing";
            this.cmdFish.UseVisualStyleBackColor = true;
            this.cmdFish.Click += new System.EventHandler(this.cmdFish_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player Name:";
            // 
            // cmdStop
            // 
            this.cmdStop.Enabled = false;
            this.cmdStop.Location = new System.Drawing.Point(377, 6);
            this.cmdStop.Margin = new System.Windows.Forms.Padding(4);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(105, 31);
            this.cmdStop.TabIndex = 4;
            this.cmdStop.Text = "Stop Fishing";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 544);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Items Caught:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(761, 540);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(185, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(956, 30);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(223, 24);
            this.toolStripStatusLabel2.Text = "Fishbot (developed by WiNiFiX)";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(86, 24);
            this.toolStripStatusLabel3.Text = "Version: {0}";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(108, 24);
            this.toolStripStatusLabel1.Text = "Build Date: {0}";
            // 
            // keptItems
            // 
            this.keptItems.ItemHeight = 16;
            this.keptItems.Items.AddRange(new object[] {
            "103_Pound_Mightfish",
            "10_Pound_Mud_Snapper",
            "12_Pound_Lobster",
            "15_Pound_Lobster",
            "15_Pound_Salmon",
            "17_Pound_Catfish",
            "19_Pound_Lobster",
            "21_Pound_Lobster",
            "22_Pound_Catfish",
            "22_Pound_Salmon",
            "25_Pound_Salmon",
            "26_Pound_Catfish",
            "29_Pound_Salmon",
            "32_Pound_Catfish",
            "32_Pound_Salmon",
            "34_Pound_Redgill",
            "40_Pound_Grouper",
            "42_Pound_Redgill",
            "45_Pound_Redgill",
            "49_Pound_Redgill",
            "52_Pound_Redgill",
            "53_Pound_Grouper",
            "59_Pound_Grouper",
            "68_Pound_Grouper",
            "70_Pound_Mightfish",
            "7_Pound_Lobster",
            "92_Pound_Mightfish",
            "Acidic_Slime",
            "Baby_Crocolisk",
            "Barbed_Gill_Trout",
            "Barrelhead_Goby",
            "Big-mouth_Clam",
            "Black_Jelly",
            "Blackfin_Darter",
            "Bloated_Barbed_Gill_Trout",
            "Bloated_Catfish",
            "Bloated_Giant_Sunfish",
            "Bloated_Mightfish",
            "Bloated_Monsterbelly",
            "Bloated_Mud_Snapper",
            "Bloated_Redgill",
            "Bloated_Rockscale_Cod",
            "Bloated_Salmon",
            "Bloated_Smallfish",
            "Bloated_Trout",
            "Bloodtooth_Frenzy",
            "Bonescale_Snapper",
            "Borean_Man_O\'_War",
            "Brilliant_Smallfish",
            "Bristle_Whisker_Catfish",
            "Broken_Engine_Part",
            "Broken_Wine_Bottle",
            "Brooding_Darkwater_Clam",
            "Brownell\'s_Blue_Striped_Racer",
            "Crescent-Tail_Skullfish",
            "Crystallized_Water",
            "Curious_Crate",
            "Dark_Herring",
            "Darkclaw_Lobster",
            "Darkwater_Clam",
            "Dented_Crate",
            "Deviate_Fish",
            "Dezian_Queenfish",
            "Dragonfin_Angelfish",
            "Dragonfin_Filet",
            "Driftwood",
            "Dustbringer",
            "Electropeller",
            "Elemental_Fire",
            "Elemental_Water",
            "Empty_Rum_Bottle",
            "Enormous_Barbed_Gill_Trout",
            "Essence_of_Fire",
            "Essence_of_Water",
            "Fangtooth_Herring",
            "Felblood_Snapper",
            "Feralas_Ahi",
            "Figluster\'s_Mudfish",
            "Filet_of_Redgill",
            "Firefin_Snapper",
            "Fountain_Goldfish",
            "Furious_Crawdad",
            "Gaffer_Jack",
            "Giant_Darkwater_Clam",
            "Giant_Freshwater_Shrimp",
            "Giant_Sunfish",
            "Glacial_Salmon",
            "Glassfin_Minnow",
            "Globe_of_Water",
            "Golden_Darter",
            "Goldenscale_Vendorfish",
            "Heart_of_Fire",
            "Heavy_Crate",
            "Heavy_Supply_Crate",
            "Huge_Spotted_Feltail",
            "Icefin_Bluefish",
            "Imperial_Manta_Ray",
            "Iron_Bound_Trunk",
            "Ironbound_Locked_Chest",
            "Jaggal_Clam",
            "Keefer\'s_Angelfish",
            "Large_Raw_Mightfish",
            "Lightning_Eel",
            "Lobster_Stew",
            "Longjaw_Mud_Snapper",
            "Magic_Eater",
            "Misty_Reed_Mahi_Mahi",
            "Mithril_Bound_Trunk",
            "Mithril_Head_Trout",
            "Monstrous_Felblood_Snapper",
            "Mote_of_Water",
            "Mr._Pinchy",
            "Musselback_Sculpin",
            "Nettlefish",
            "Oil_Covered_Fish",
            "Oil_Spill_Grouper",
            "Oily_Blackmouth",
            "Old_Boot",
            "Old_Crafty",
            "Old_Ironjaw",
            "Old_Skull",
            "Old_Teamster\'s_Skull",
            "Old_Wagonwheel",
            "Peacebloom",
            "Phantom_Ghostfish",
            "Plated_Armorfish",
            "Pygmy_Suckerfish",
            "Rainbow_Fin_Albacore",
            "Raw_Brilliant_Smallfish",
            "Raw_Bristle_Whisker_Catfish",
            "Raw_Glossy_Mightfish",
            "Raw_Greater_Sagefish",
            "Raw_Loch_Frenzy",
            "Raw_Longjaw_Mud_Snapper",
            "Raw_Mithril_Head_Trout",
            "Raw_Nightfin_Snapper",
            "Raw_Rainbow_Fin_Albacore",
            "Raw_Redgill",
            "Raw_Rockscale_Cod",
            "Raw_Sagefish",
            "Raw_Slitherskin_Mackerel",
            "Raw_Spotted_Yellowtail",
            "Raw_Summer_Bass",
            "Raw_Sunscale_Salmon",
            "Raw_Whitescale_Salmon",
            "Red_Snapper_Grouper",
            "Reinforced_Crate",
            "Reinforced_Locked_Chest",
            "Rock",
            "Rockhide_Strongfish",
            "Rockscale_Cod",
            "Rusted_Engineering_Parts",
            "Sar\'theris_Striker",
            "Sauteed_Goby",
            "Savage_Coast_Blue_Sailfin",
            "Sealed_Crate",
            "Seaweed",
            "Sewer_Carp",
            "Shimmering_Minnow",
            "Sickly_Fish",
            "Sickly_Looking_Fish",
            "Slippery_Eel",
            "Slitherskin_Mackerel",
            "Small_Barnacled_Clam",
            "Small_Locked_Chest",
            "Speckled_Tastyfish",
            "Spotted_Feltail",
            "Spotted_Sunfish",
            "Spotted_Yellowtail",
            "Steam_Pump_Debris",
            "Steelscale_Crushfish",
            "Stewed_Trout",
            "Stonescale_Eel",
            "Strange_Engine_Par",
            "Stranglekelp",
            "Sturdy_Locked_Chest",
            "Tangled_Fishing_Line",
            "Tasty_Reef_Fish",
            "Tattered_Cloth",
            "Terrorfish",
            "The_1_Ring",
            "Thick-shelled_Clam",
            "Tightly_Sealed_Trunk",
            "Tree_Branch",
            "Water_Snail",
            "Waterlogged_Crate",
            "Watertight_Trunk",
            "Weeds",
            "Winter_Squid",
            "World\'s_Largest_Mudfish",
            "Zangarian_Sporefish"});
            this.keptItems.Location = new System.Drawing.Point(519, 74);
            this.keptItems.Name = "keptItems";
            this.keptItems.Size = new System.Drawing.Size(170, 452);
            this.keptItems.TabIndex = 0;
            this.keptItems.SelectedIndexChanged += new System.EventHandler(this.keptItems_SelectedIndexChanged);
            // 
            // dropItems
            // 
            this.dropItems.ItemHeight = 16;
            this.dropItems.Location = new System.Drawing.Point(775, 74);
            this.dropItems.Name = "dropItems";
            this.dropItems.Size = new System.Drawing.Size(170, 452);
            this.dropItems.TabIndex = 0;
            // 
            // keptToDropButton
            // 
            this.keptToDropButton.Location = new System.Drawing.Point(702, 141);
            this.keptToDropButton.Name = "keptToDropButton";
            this.keptToDropButton.Size = new System.Drawing.Size(59, 23);
            this.keptToDropButton.TabIndex = 0;
            this.keptToDropButton.Text = "-->";
            this.keptToDropButton.Click += new System.EventHandler(this.keptToDropButton_Click);
            // 
            // dropToKeptButton
            // 
            this.dropToKeptButton.Location = new System.Drawing.Point(702, 219);
            this.dropToKeptButton.Name = "dropToKeptButton";
            this.dropToKeptButton.Size = new System.Drawing.Size(59, 23);
            this.dropToKeptButton.TabIndex = 0;
            this.dropToKeptButton.Text = "<--";
            this.dropToKeptButton.Click += new System.EventHandler(this.dropToKeptButton_Click);
            // 
            // keptItemsLabel
            // 
            this.keptItemsLabel.Location = new System.Drawing.Point(560, 51);
            this.keptItemsLabel.Name = "keptItemsLabel";
            this.keptItemsLabel.Size = new System.Drawing.Size(74, 17);
            this.keptItemsLabel.TabIndex = 3;
            this.keptItemsLabel.Text = "Kept Items";
            // 
            // dropItemsLabel
            // 
            this.dropItemsLabel.Location = new System.Drawing.Point(813, 51);
            this.dropItemsLabel.Name = "dropItemsLabel";
            this.dropItemsLabel.Size = new System.Drawing.Size(100, 23);
            this.dropItemsLabel.TabIndex = 26;
            this.dropItemsLabel.Text = "Deleted Items";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 604);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdFish);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.keptItems);
            this.Controls.Add(this.dropItems);
            this.Controls.Add(this.keptToDropButton);
            this.Controls.Add(this.dropToKeptButton);
            this.Controls.Add(this.keptItemsLabel);
            this.Controls.Add(this.dropItemsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fishbot - [WoW Version: 3.3.5a]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.Button cmdFish;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ListBox keptItems;
        public System.Windows.Forms.ListBox dropItems;
        public System.Windows.Forms.Button keptToDropButton;
        public System.Windows.Forms.Button dropToKeptButton;
        public System.Windows.Forms.Label keptItemsLabel;
        public System.Windows.Forms.Label dropItemsLabel;
    }
}

