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
            "103 Pound Mightfish",
            "10 Pound Mud Snapper",
            "12 Pound Lobster",
            "15 Pound Lobster",
            "15 Pound Salmon",
            "17 Pound Catfish",
            "19 Pound Lobster",
            "21 Pound Lobster",
            "22 Pound Catfish",
            "22 Pound Salmon",
            "25 Pound Salmon",
            "26 Pound Catfish",
            "29 Pound Salmon",
            "32 Pound Catfish",
            "32 Pound Salmon",
            "34 Pound Redgill",
            "40 Pound Grouper",
            "42 Pound Redgill",
            "45 Pound Redgill",
            "49 Pound Redgill",
            "52 Pound Redgill",
            "53 Pound Grouper",
            "59 Pound Grouper",
            "68 Pound Grouper",
            "70 Pound Mightfish",
            "7 Pound Lobster",
            "92 Pound Mightfish",
            "Acidic Slime",
            "Baby Crocolisk",
            "Barbed Gill Trout",
            "Barrelhead Goby",
            "Big-mouth Clam",
            "Black Jelly",
            "Blackfin Darter",
            "Bloated Barbed Gill Trout",
            "Bloated Catfish",
            "Bloated Giant Sunfish",
            "Bloated Mightfish",
            "Bloated Monsterbelly",
            "Bloated Mud Snapper",
            "Bloated Redgill",
            "Bloated Rockscale Cod",
            "Bloated Salmon",
            "Bloated Smallfish",
            "Bloated Trout",
            "Bloodtooth Frenzy",
            "Bonescale Snapper",
            "Borean Man O\' War",
            "Brilliant Smallfish",
            "Bristle Whisker Catfish",
            "Broken Engine Part",
            "Broken Wine Bottle",
            "Brooding Darkwater Clam",
            "Brownell\'s Blue Striped Racer",
            "Crescent-Tail Skullfish",
            "Crystallized Water",
            "Curious Crate",
            "Dark Herring",
            "Darkclaw Lobster",
            "Darkwater Clam",
            "Dented Crate",
            "Deviate Fish",
            "Dezian Queenfish",
            "Dragonfin Angelfish",
            "Dragonfin Filet",
            "Driftwood",
            "Dustbringer",
            "Electropeller",
            "Elemental Fire",
            "Elemental Water",
            "Empty Rum Bottle",
            "Enormous Barbed Gill Trout",
            "Essence of Fire",
            "Essence of Water",
            "Fangtooth Herring",
            "Felblood Snapper",
            "Feralas Ahi",
            "Figluster\'s Mudfish",
            "Filet of Redgill",
            "Firefin Snapper",
            "Fountain Goldfish",
            "Furious Crawdad",
            "Gaffer Jack",
            "Giant Darkwater Clam",
            "Giant Freshwater Shrimp",
            "Giant Sunfish",
            "Glacial Salmon",
            "Glassfin Minnow",
            "Globe of Water",
            "Golden Darter",
            "Goldenscale Vendorfish",
            "Heart of Fire",
            "Heavy Crate",
            "Heavy Supply Crate",
            "Huge Spotted Feltail",
            "Icefin Bluefish",
            "Imperial Manta Ray",
            "Iron Bound Trunk",
            "Ironbound Locked Chest",
            "Jaggal Clam",
            "Keefer\'s Angelfish",
            "Large Raw Mightfish",
            "Lightning Eel",
            "Lobster Stew",
            "Longjaw Mud Snapper",
            "Magic Eater",
            "Misty Reed Mahi Mahi",
            "Mithril Bound Trunk",
            "Mithril Head Trout",
            "Monstrous Felblood Snapper",
            "Mote of Water",
            "Mr. Pinchy",
            "Musselback Sculpin",
            "Nettlefish",
            "Oil Covered Fish",
            "Oil Spill Grouper",
            "Oily Blackmouth",
            "Old Boot",
            "Old Crafty",
            "Old Ironjaw",
            "Old Skull",
            "Old Teamster\'s Skull",
            "Old Wagonwheel",
            "Peacebloom",
            "Phantom Ghostfish",
            "Plated Armorfish",
            "Pygmy Suckerfish",
            "Rainbow Fin Albacore",
            "Raw Brilliant Smallfish",
            "Raw Bristle Whisker Catfish",
            "Raw Glossy Mightfish",
            "Raw Greater Sagefish",
            "Raw Loch Frenzy",
            "Raw Longjaw Mud Snapper",
            "Raw Mithril Head Trout",
            "Raw Nightfin Snapper",
            "Raw Rainbow Fin Albacore",
            "Raw Redgill",
            "Raw Rockscale Cod",
            "Raw Sagefish",
            "Raw Slitherskin Mackerel",
            "Raw Spotted Yellowtail",
            "Raw Summer Bass",
            "Raw Sunscale Salmon",
            "Raw Whitescale Salmon",
            "Red Snapper Grouper",
            "Reinforced Crate",
            "Reinforced Locked Chest",
            "Rock",
            "Rockhide Strongfish",
            "Rockscale Cod",
            "Rusted Engineering Parts",
            "Sar\'theris Striker",
            "Sauteed Goby",
            "Savage Coast Blue Sailfin",
            "Sealed Crate",
            "Seaweed",
            "Sewer Carp",
            "Shimmering Minnow",
            "Sickly Fish",
            "Sickly Looking Fish",
            "Slippery Eel",
            "Slitherskin Mackerel",
            "Small Barnacled Clam",
            "Small Locked Chest",
            "Speckled Tastyfish",
            "Spotted Feltail",
            "Spotted Sunfish",
            "Spotted Yellowtail",
            "Steam Pump Debris",
            "Steelscale Crushfish",
            "Stewed Trout",
            "Stonescale Eel",
            "Strange Engine Par",
            "Stranglekelp",
            "Sturdy Locked Chest",
            "Tangled Fishing Line",
            "Tasty Reef Fish",
            "Tattered Cloth",
            "Terrorfish",
            "The 1 Ring",
            "Thick-shelled Clam",
            "Tightly Sealed Trunk",
            "Tree Branch",
            "Water Snail",
            "Waterlogged Crate",
            "Watertight Trunk",
            "Weeds",
            "Winter Squid",
            "World\'s Largest Mudfish",
            "Zangarian Sporefish"});
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

