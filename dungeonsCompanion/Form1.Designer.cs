namespace Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.charComboBox = new System.Windows.Forms.ComboBox();
            this.wisComboBox = new System.Windows.Forms.ComboBox();
            this.intComboBox = new System.Windows.Forms.ComboBox();
            this.constComboBox = new System.Windows.Forms.ComboBox();
            this.dexComboBox = new System.Windows.Forms.ComboBox();
            this.strComboBox = new System.Windows.Forms.ComboBox();
            this.baseLabel = new System.Windows.Forms.Label();
            this.modLabel = new System.Windows.Forms.Label();
            this.charModBox = new System.Windows.Forms.TextBox();
            this.wisModBox = new System.Windows.Forms.TextBox();
            this.intModBox = new System.Windows.Forms.TextBox();
            this.constModBox = new System.Windows.Forms.TextBox();
            this.dexModBox = new System.Windows.Forms.TextBox();
            this.strModBox = new System.Windows.Forms.TextBox();
            this.characterName = new System.Windows.Forms.Label();
            this.characterNameBox = new System.Windows.Forms.TextBox();
            this.backgroundBox = new System.Windows.Forms.ComboBox();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.strLabel = new System.Windows.Forms.Label();
            this.playernameTextbox = new System.Windows.Forms.TextBox();
            this.playernameLabel = new System.Windows.Forms.Label();
            this.dexLabel = new System.Windows.Forms.Label();
            this.constLabel = new System.Windows.Forms.Label();
            this.intLabel = new System.Windows.Forms.Label();
            this.raceBox = new System.Windows.Forms.ComboBox();
            this.wizLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.charLabel = new System.Windows.Forms.Label();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            this.fileToolStripMenuItem.MouseHover += new System.EventHandler(this.fileToolStripMenuItem_MouseHover);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.openToolStripMenuItem.Text = "Import CSV";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveToolStripMenuItem.Text = "Export to CSV";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            this.closeToolStripMenuItem.MouseHover += new System.EventHandler(this.closeToolStripMenuItem_MouseHover);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutThisAppToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutThisAppToolStripMenuItem
            // 
            this.aboutThisAppToolStripMenuItem.Name = "aboutThisAppToolStripMenuItem";
            this.aboutThisAppToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutThisAppToolStripMenuItem.Text = "About this App";
            this.aboutThisAppToolStripMenuItem.Click += new System.EventHandler(this.aboutThisAppToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 92);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 529);
            this.tabControl1.TabIndex = 33;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::dungeonsCompanion.Properties.Resources.wallpaper;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.loadButton);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.charComboBox);
            this.tabPage1.Controls.Add(this.wisComboBox);
            this.tabPage1.Controls.Add(this.intComboBox);
            this.tabPage1.Controls.Add(this.constComboBox);
            this.tabPage1.Controls.Add(this.dexComboBox);
            this.tabPage1.Controls.Add(this.strComboBox);
            this.tabPage1.Controls.Add(this.baseLabel);
            this.tabPage1.Controls.Add(this.modLabel);
            this.tabPage1.Controls.Add(this.charModBox);
            this.tabPage1.Controls.Add(this.wisModBox);
            this.tabPage1.Controls.Add(this.intModBox);
            this.tabPage1.Controls.Add(this.constModBox);
            this.tabPage1.Controls.Add(this.dexModBox);
            this.tabPage1.Controls.Add(this.strModBox);
            this.tabPage1.Controls.Add(this.characterName);
            this.tabPage1.Controls.Add(this.characterNameBox);
            this.tabPage1.Controls.Add(this.backgroundBox);
            this.tabPage1.Controls.Add(this.backgroundLabel);
            this.tabPage1.Controls.Add(this.strLabel);
            this.tabPage1.Controls.Add(this.playernameTextbox);
            this.tabPage1.Controls.Add(this.playernameLabel);
            this.tabPage1.Controls.Add(this.dexLabel);
            this.tabPage1.Controls.Add(this.constLabel);
            this.tabPage1.Controls.Add(this.intLabel);
            this.tabPage1.Controls.Add(this.raceBox);
            this.tabPage1.Controls.Add(this.wizLabel);
            this.tabPage1.Controls.Add(this.raceLabel);
            this.tabPage1.Controls.Add(this.charLabel);
            this.tabPage1.Controls.Add(this.classBox);
            this.tabPage1.Controls.Add(this.classLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Character Sheet";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(96, 245);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 41;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // charComboBox
            // 
            this.charComboBox.FormattingEnabled = true;
            this.charComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.charComboBox.Location = new System.Drawing.Point(60, 209);
            this.charComboBox.Name = "charComboBox";
            this.charComboBox.Size = new System.Drawing.Size(50, 21);
            this.charComboBox.TabIndex = 11;
            this.charComboBox.TextChanged += new System.EventHandler(this.charComboBox_TextChanged);
            // 
            // wisComboBox
            // 
            this.wisComboBox.FormattingEnabled = true;
            this.wisComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.wisComboBox.Location = new System.Drawing.Point(60, 183);
            this.wisComboBox.Name = "wisComboBox";
            this.wisComboBox.Size = new System.Drawing.Size(50, 21);
            this.wisComboBox.TabIndex = 10;
            this.wisComboBox.TextChanged += new System.EventHandler(this.wisComboBox_TextChanged);
            // 
            // intComboBox
            // 
            this.intComboBox.FormattingEnabled = true;
            this.intComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.intComboBox.Location = new System.Drawing.Point(60, 157);
            this.intComboBox.Name = "intComboBox";
            this.intComboBox.Size = new System.Drawing.Size(50, 21);
            this.intComboBox.TabIndex = 9;
            this.intComboBox.TextChanged += new System.EventHandler(this.intComboBox_TextChanged);
            // 
            // constComboBox
            // 
            this.constComboBox.FormattingEnabled = true;
            this.constComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.constComboBox.Location = new System.Drawing.Point(60, 131);
            this.constComboBox.Name = "constComboBox";
            this.constComboBox.Size = new System.Drawing.Size(50, 21);
            this.constComboBox.TabIndex = 8;
            this.constComboBox.TextChanged += new System.EventHandler(this.constComboBox_TextChanged);
            // 
            // dexComboBox
            // 
            this.dexComboBox.FormattingEnabled = true;
            this.dexComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.dexComboBox.Location = new System.Drawing.Point(60, 105);
            this.dexComboBox.Name = "dexComboBox";
            this.dexComboBox.Size = new System.Drawing.Size(50, 21);
            this.dexComboBox.TabIndex = 7;
            this.dexComboBox.TextChanged += new System.EventHandler(this.dexComboBox_TextChanged);
            // 
            // strComboBox
            // 
            this.strComboBox.FormattingEnabled = true;
            this.strComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.strComboBox.Location = new System.Drawing.Point(60, 79);
            this.strComboBox.Name = "strComboBox";
            this.strComboBox.Size = new System.Drawing.Size(50, 21);
            this.strComboBox.TabIndex = 6;
            this.strComboBox.SelectedValueChanged += new System.EventHandler(this.strComboBox_SelectedValueChanged);
            this.strComboBox.TextChanged += new System.EventHandler(this.strComboBox_TextChanged);
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(79, 64);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(31, 13);
            this.baseLabel.TabIndex = 40;
            this.baseLabel.Text = "Base";
            // 
            // modLabel
            // 
            this.modLabel.AutoSize = true;
            this.modLabel.Location = new System.Drawing.Point(24, 64);
            this.modLabel.Name = "modLabel";
            this.modLabel.Size = new System.Drawing.Size(28, 13);
            this.modLabel.TabIndex = 39;
            this.modLabel.Text = "Mod";
            // 
            // charModBox
            // 
            this.charModBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.charModBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.charModBox.Location = new System.Drawing.Point(9, 210);
            this.charModBox.Name = "charModBox";
            this.charModBox.ReadOnly = true;
            this.charModBox.Size = new System.Drawing.Size(43, 20);
            this.charModBox.TabIndex = 38;
            this.charModBox.TabStop = false;
            this.charModBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // wisModBox
            // 
            this.wisModBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wisModBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.wisModBox.Location = new System.Drawing.Point(9, 184);
            this.wisModBox.Name = "wisModBox";
            this.wisModBox.ReadOnly = true;
            this.wisModBox.Size = new System.Drawing.Size(43, 20);
            this.wisModBox.TabIndex = 37;
            this.wisModBox.TabStop = false;
            this.wisModBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // intModBox
            // 
            this.intModBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intModBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.intModBox.Location = new System.Drawing.Point(9, 158);
            this.intModBox.Name = "intModBox";
            this.intModBox.ReadOnly = true;
            this.intModBox.Size = new System.Drawing.Size(43, 20);
            this.intModBox.TabIndex = 36;
            this.intModBox.TabStop = false;
            this.intModBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // constModBox
            // 
            this.constModBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.constModBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.constModBox.Location = new System.Drawing.Point(9, 132);
            this.constModBox.Name = "constModBox";
            this.constModBox.ReadOnly = true;
            this.constModBox.Size = new System.Drawing.Size(43, 20);
            this.constModBox.TabIndex = 35;
            this.constModBox.TabStop = false;
            this.constModBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dexModBox
            // 
            this.dexModBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dexModBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.dexModBox.Location = new System.Drawing.Point(9, 106);
            this.dexModBox.Name = "dexModBox";
            this.dexModBox.ReadOnly = true;
            this.dexModBox.Size = new System.Drawing.Size(43, 20);
            this.dexModBox.TabIndex = 34;
            this.dexModBox.TabStop = false;
            this.dexModBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // strModBox
            // 
            this.strModBox.BackColor = System.Drawing.SystemColors.Control;
            this.strModBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.strModBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.strModBox.Location = new System.Drawing.Point(9, 80);
            this.strModBox.Name = "strModBox";
            this.strModBox.ReadOnly = true;
            this.strModBox.Size = new System.Drawing.Size(43, 20);
            this.strModBox.TabIndex = 33;
            this.strModBox.TabStop = false;
            this.strModBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // characterName
            // 
            this.characterName.AutoSize = true;
            this.characterName.Location = new System.Drawing.Point(6, 16);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(84, 13);
            this.characterName.TabIndex = 3;
            this.characterName.Text = "Character Name";
            this.characterName.Click += new System.EventHandler(this.label1_Click);
            // 
            // characterNameBox
            // 
            this.characterNameBox.Location = new System.Drawing.Point(9, 32);
            this.characterNameBox.Name = "characterNameBox";
            this.characterNameBox.Size = new System.Drawing.Size(127, 20);
            this.characterNameBox.TabIndex = 1;
            // 
            // backgroundBox
            // 
            this.backgroundBox.FormattingEnabled = true;
            this.backgroundBox.Items.AddRange(new object[] {
            "Abandoned",
            "Adventurer",
            "Afflicted",
            "Air Acrobat",
            "Alchemic Construct",
            "Alchemist",
            "Alcoholic",
            "Amnesiac",
            "Ancient Cultist",
            "Antiquarian",
            "Apothecary",
            "Arcana Spy",
            "Arcane Dominion",
            "Artist",
            "Arvoreen Keeper",
            "Aspirant",
            "Astronaut",
            "Barmaid",
            "Battlesmith",
            "Blood luster",
            "Bounty Hunter",
            "Butler",
            "Captain",
            "Cattle Rustler",
            "Changeling",
            "Child of Ares",
            "City Guard",
            "City Worker",
            "Clone",
            "Combat Medic",
            "Confederacy of Feuding Houses",
            "Cook",
            "Courtesan",
            "Crazed Hermit",
            "Crusader Nation",
            "Cults X-Golden Child",
            "Cursed",
            "Dark Lord",
            "Demonologist",
            "Denizen",
            "Diplomat",
            "Disgrace",
            "Disowned Noble",
            "Divine",
            "Doctor",
            "Dog of the Military",
            "Dragon Trained",
            "Drunken Bum",
            "Drunken Pirate",
            "Earthling",
            "Elysium Knight",
            "Engineer",
            "Envoy",
            "Eternal One",
            "Evil Cultist",
            "Executioner",
            "Exile",
            "Exiled Ruler",
            "Experiment",
            "Explorer",
            "Falconer",
            "Farmer",
            "Feral Child",
            "Fey Child",
            "Firefighter",
            "Futureborn",
            "Gambler",
            "Gladiator",
            "Governess",
            "Heir of a Fallen Kingdom",
            "Hellborn",
            "Herald of the Gods",
            "Heretic",
            "Hooded Figure",
            "Hunter",
            "Immortal",
            "Innkeeper",
            "Inquirer",
            "Islander",
            "Janitor",
            "Jester",
            "Law Bringer",
            "Law Bringer (Variant)",
            "Librarian",
            "Lone Survivor",
            "Lost Civilization",
            "Lover",
            "Mage Hunter",
            "Maid",
            "Mailman",
            "Marshal",
            "Master Inquisitor",
            "Mercenary",
            "Messenger",
            "Metal Worker",
            "Military Asset",
            "Military Pilot",
            "Monastic",
            "Monastic Traveller",
            "Monster",
            "Monster Hunter",
            "Mute",
            "Mystic",
            "Noble (Variant)",
            "Noble Guard",
            "Nomad",
            "Oathbreaker",
            "Occult Investigator",
            "Otherworlder, Variant",
            "Otherworlder",
            "Paradox",
            "Pilot",
            "Plane Walker",
            "Politician",
            "Princess/Prince",
            "Prisoner",
            "Proctor",
            "Prodigy",
            "Professional Assassin",
            "Prospector",
            "Psychic",
            "Redeemed Cultist",
            "Regime of the Dark Overlord",
            "Revenant",
            "Revolutionist",
            "Royal Cavalryman",
            "Royalty",
            "Savage Land",
            "Scavenger",
            "Scout",
            "Secret",
            "Seeker",
            "Sentinel",
            "Serial Killer",
            "Sex Worker",
            "Shadow Bringer",
            "Shadow Thieves\' Guild Member",
            "Shipwright",
            "Slave",
            "Slayer",
            "Smuggler",
            "Spy",
            "Squire",
            "Student of Magic",
            "Survivor",
            "Tailor",
            "Test Subject",
            "The Chosen One",
            "Torturer",
            "Unknown",
            "Urban Vigilante",
            "Vagrant Trouper",
            "Vaquero",
            "Venator",
            "Witch Hunter",
            "Wolf Knight",
            "Woodcutter",
            "Wooddweller",
            "Worshipped One",
            "Writer",
            "Zealot"});
            this.backgroundBox.Location = new System.Drawing.Point(196, 70);
            this.backgroundBox.Name = "backgroundBox";
            this.backgroundBox.Size = new System.Drawing.Size(121, 21);
            this.backgroundBox.TabIndex = 5;
            this.backgroundBox.Text = "...";
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.AutoSize = true;
            this.backgroundLabel.Location = new System.Drawing.Point(193, 54);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(65, 13);
            this.backgroundLabel.TabIndex = 31;
            this.backgroundLabel.Text = "Background";
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Location = new System.Drawing.Point(116, 83);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(47, 13);
            this.strLabel.TabIndex = 8;
            this.strLabel.Text = "Strength";
            this.strLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // playernameTextbox
            // 
            this.playernameTextbox.Location = new System.Drawing.Point(196, 31);
            this.playernameTextbox.Name = "playernameTextbox";
            this.playernameTextbox.Size = new System.Drawing.Size(127, 20);
            this.playernameTextbox.TabIndex = 2;
            // 
            // playernameLabel
            // 
            this.playernameLabel.AutoSize = true;
            this.playernameLabel.Location = new System.Drawing.Point(193, 15);
            this.playernameLabel.Name = "playernameLabel";
            this.playernameLabel.Size = new System.Drawing.Size(67, 13);
            this.playernameLabel.TabIndex = 29;
            this.playernameLabel.Text = "Player Name";
            // 
            // dexLabel
            // 
            this.dexLabel.AutoSize = true;
            this.dexLabel.Location = new System.Drawing.Point(116, 109);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(48, 13);
            this.dexLabel.TabIndex = 14;
            this.dexLabel.Text = "Dexterity";
            // 
            // constLabel
            // 
            this.constLabel.AutoSize = true;
            this.constLabel.Location = new System.Drawing.Point(116, 135);
            this.constLabel.Name = "constLabel";
            this.constLabel.Size = new System.Drawing.Size(62, 13);
            this.constLabel.TabIndex = 15;
            this.constLabel.Text = "Constitution";
            // 
            // intLabel
            // 
            this.intLabel.AutoSize = true;
            this.intLabel.Location = new System.Drawing.Point(116, 161);
            this.intLabel.Name = "intLabel";
            this.intLabel.Size = new System.Drawing.Size(61, 13);
            this.intLabel.TabIndex = 16;
            this.intLabel.Text = "Intelligence";
            // 
            // raceBox
            // 
            this.raceBox.FormattingEnabled = true;
            this.raceBox.Items.AddRange(new object[] {
            "Dragonborn",
            "Dwarf",
            "Eladrin",
            "Elf",
            "Gnome",
            "Half-elf",
            "Half-orc",
            "Halfling",
            "Human ",
            "Tiefling"});
            this.raceBox.Location = new System.Drawing.Point(456, 30);
            this.raceBox.Name = "raceBox";
            this.raceBox.Size = new System.Drawing.Size(121, 21);
            this.raceBox.TabIndex = 4;
            this.raceBox.Text = "...";
            this.raceBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // wizLabel
            // 
            this.wizLabel.AutoSize = true;
            this.wizLabel.Location = new System.Drawing.Point(116, 187);
            this.wizLabel.Name = "wizLabel";
            this.wizLabel.Size = new System.Drawing.Size(45, 13);
            this.wizLabel.TabIndex = 17;
            this.wizLabel.Text = "Wisdom";
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(453, 14);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(33, 13);
            this.raceLabel.TabIndex = 21;
            this.raceLabel.Text = "Race";
            // 
            // charLabel
            // 
            this.charLabel.AutoSize = true;
            this.charLabel.Location = new System.Drawing.Point(116, 213);
            this.charLabel.Name = "charLabel";
            this.charLabel.Size = new System.Drawing.Size(50, 13);
            this.charLabel.TabIndex = 18;
            this.charLabel.Text = "Charisma";
            // 
            // classBox
            // 
            this.classBox.FormattingEnabled = true;
            this.classBox.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard"});
            this.classBox.Location = new System.Drawing.Point(329, 30);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(121, 21);
            this.classBox.TabIndex = 3;
            this.classBox.Text = "...";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(326, 14);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(32, 13);
            this.classLabel.TabIndex = 19;
            this.classLabel.Text = "Class";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(15, 245);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 42;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(588, 555);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeons Companion";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.Label characterName;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.Label dexLabel;
        private System.Windows.Forms.Label constLabel;
        private System.Windows.Forms.Label intLabel;
        private System.Windows.Forms.Label wizLabel;
        private System.Windows.Forms.Label charLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ComboBox classBox;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.ComboBox raceBox;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label playernameLabel;
        private System.Windows.Forms.TextBox playernameTextbox;
        private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.ComboBox backgroundBox;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label modLabel;
        private System.Windows.Forms.TextBox charModBox;
        private System.Windows.Forms.TextBox wisModBox;
        private System.Windows.Forms.TextBox intModBox;
        private System.Windows.Forms.TextBox constModBox;
        private System.Windows.Forms.TextBox dexModBox;
        private System.Windows.Forms.TextBox strModBox;
        private System.Windows.Forms.ComboBox charComboBox;
        private System.Windows.Forms.ComboBox wisComboBox;
        private System.Windows.Forms.ComboBox intComboBox;
        private System.Windows.Forms.ComboBox constComboBox;
        private System.Windows.Forms.ComboBox dexComboBox;
        private System.Windows.Forms.ComboBox strComboBox;
        private System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.TextBox characterNameBox;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button loadButton;
    }
}

