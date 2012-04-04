namespace TagApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ifSubfolders = new System.Windows.Forms.CheckBox();
            this.isFilePathGiven = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.właściwościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.addDirBut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.FileOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Track = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Composer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearTableBut = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narzędziaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szablonyTagówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualizacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indeksPomocyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.ifSubfolders);
            this.groupBox1.Controls.Add(this.isFilePathGiven);
            this.groupBox1.Controls.Add(this.directoryTextBox);
            this.groupBox1.Controls.Add(this.addDirBut);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 521);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ładowanie Folderu";
            // 
            // ifSubfolders
            // 
            this.ifSubfolders.AutoSize = true;
            this.ifSubfolders.Location = new System.Drawing.Point(10, 67);
            this.ifSubfolders.Name = "ifSubfolders";
            this.ifSubfolders.Size = new System.Drawing.Size(134, 17);
            this.ifSubfolders.TabIndex = 8;
            this.ifSubfolders.Text = "Szukaj w podfolderach";
            this.ifSubfolders.UseVisualStyleBackColor = true;
            // 
            // isFilePathGiven
            // 
            this.isFilePathGiven.AutoSize = true;
            this.isFilePathGiven.ContextMenuStrip = this.contextMenuStrip1;
            this.isFilePathGiven.Location = new System.Drawing.Point(4, 110);
            this.isFilePathGiven.Name = "isFilePathGiven";
            this.isFilePathGiven.Size = new System.Drawing.Size(66, 13);
            this.isFilePathGiven.TabIndex = 2;
            this.isFilePathGiven.Text = "Brak Ścieżki";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.właściwościToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 26);
            // 
            // właściwościToolStripMenuItem
            // 
            this.właściwościToolStripMenuItem.Name = "właściwościToolStripMenuItem";
            this.właściwościToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.właściwościToolStripMenuItem.Text = "Właściwości";
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(7, 37);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(211, 20);
            this.directoryTextBox.TabIndex = 1;
            // 
            // addDirBut
            // 
            this.addDirBut.Location = new System.Drawing.Point(143, 63);
            this.addDirBut.Name = "addDirBut";
            this.addDirBut.Size = new System.Drawing.Size(75, 23);
            this.addDirBut.TabIndex = 0;
            this.addDirBut.Text = "Dodaj folder";
            this.addDirBut.UseVisualStyleBackColor = true;
            this.addDirBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.mainGrid);
            this.groupBox2.Location = new System.Drawing.Point(242, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 521);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Szczegóły plików";
            // 
            // mainGrid
            // 
            this.mainGrid.AllowDrop = true;
            this.mainGrid.AllowUserToAddRows = false;
            this.mainGrid.AllowUserToDeleteRows = false;
            this.mainGrid.AllowUserToResizeRows = false;
            this.mainGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileOrderNumber,
            this.Filename,
            this.Artist,
            this.Title,
            this.Album,
            this.Track,
            this.AlbumArtist,
            this.Discnumber,
            this.Year,
            this.Genre,
            this.Comment,
            this.Composer,
            this.Cover,
            this.Tag,
            this.BPM,
            this.Path});
            this.mainGrid.Location = new System.Drawing.Point(6, 20);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowHeadersVisible = false;
            this.mainGrid.Size = new System.Drawing.Size(782, 482);
            this.mainGrid.TabIndex = 0;
            this.mainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.mainGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainGrid_CellEndEdit);
            // 
            // FileOrderNumber
            // 
            this.FileOrderNumber.Frozen = true;
            this.FileOrderNumber.HeaderText = "L.P.";
            this.FileOrderNumber.MaxInputLength = 10;
            this.FileOrderNumber.Name = "FileOrderNumber";
            this.FileOrderNumber.ReadOnly = true;
            this.FileOrderNumber.Width = 25;
            // 
            // Filename
            // 
            this.Filename.HeaderText = "Filename";
            this.Filename.MaxInputLength = 255;
            this.Filename.Name = "Filename";
            this.Filename.Width = 150;
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artist";
            this.Artist.MaxInputLength = 1024;
            this.Artist.Name = "Artist";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Album
            // 
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            // 
            // Track
            // 
            this.Track.HeaderText = "Track";
            this.Track.MaxInputLength = 5;
            this.Track.Name = "Track";
            // 
            // AlbumArtist
            // 
            this.AlbumArtist.HeaderText = "Album Artist";
            this.AlbumArtist.Name = "AlbumArtist";
            // 
            // Discnumber
            // 
            this.Discnumber.HeaderText = "Disc number";
            this.Discnumber.MaxInputLength = 3;
            this.Discnumber.Name = "Discnumber";
            this.Discnumber.Width = 30;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.MaxInputLength = 4;
            this.Year.Name = "Year";
            this.Year.Width = 40;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            // 
            // Composer
            // 
            this.Composer.HeaderText = "Composer";
            this.Composer.Name = "Composer";
            // 
            // Cover
            // 
            this.Cover.HeaderText = "Cover";
            this.Cover.Name = "Cover";
            // 
            // Tag
            // 
            this.Tag.HeaderText = "Tag";
            this.Tag.Name = "Tag";
            // 
            // BPM
            // 
            this.BPM.HeaderText = "BPM";
            this.BPM.Name = "BPM";
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            // 
            // clearTableBut
            // 
            this.clearTableBut.Location = new System.Drawing.Point(883, 602);
            this.clearTableBut.Name = "clearTableBut";
            this.clearTableBut.Size = new System.Drawing.Size(153, 23);
            this.clearTableBut.TabIndex = 2;
            this.clearTableBut.Text = "Wyczyść tabelę";
            this.clearTableBut.UseVisualStyleBackColor = true;
            this.clearTableBut.Click += new System.EventHandler(this.clearTableBut_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1048, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 16);
            this.toolStripProgressBar1.Step = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.narzędziaToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzPlikToolStripMenuItem,
            this.otwórzFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzPlikToolStripMenuItem
            // 
            this.otwórzPlikToolStripMenuItem.Name = "otwórzPlikToolStripMenuItem";
            this.otwórzPlikToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzPlikToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.otwórzPlikToolStripMenuItem.Text = "Otwórz Plik...";
            this.otwórzPlikToolStripMenuItem.Click += new System.EventHandler(this.otwórzPlikToolStripMenuItem_Click);
            // 
            // otwórzFolderToolStripMenuItem
            // 
            this.otwórzFolderToolStripMenuItem.Name = "otwórzFolderToolStripMenuItem";
            this.otwórzFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.otwórzFolderToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.otwórzFolderToolStripMenuItem.Text = "Otwórz Folder...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem1.Text = "Zapisz";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // narzędziaToolStripMenuItem
            // 
            this.narzędziaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szablonyTagówToolStripMenuItem,
            this.normalizatorToolStripMenuItem,
            this.toolStripMenuItem2,
            this.opcjeToolStripMenuItem});
            this.narzędziaToolStripMenuItem.Name = "narzędziaToolStripMenuItem";
            this.narzędziaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narzędziaToolStripMenuItem.Text = "Narzędzia";
            this.narzędziaToolStripMenuItem.Click += new System.EventHandler(this.narzędziaToolStripMenuItem_Click);
            // 
            // szablonyTagówToolStripMenuItem
            // 
            this.szablonyTagówToolStripMenuItem.Name = "szablonyTagówToolStripMenuItem";
            this.szablonyTagówToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.szablonyTagówToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.szablonyTagówToolStripMenuItem.Text = "Szablony Nazewnictwa";
            this.szablonyTagówToolStripMenuItem.Click += new System.EventHandler(this.szablonyTagówToolStripMenuItem_Click);
            // 
            // normalizatorToolStripMenuItem
            // 
            this.normalizatorToolStripMenuItem.Name = "normalizatorToolStripMenuItem";
            this.normalizatorToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.normalizatorToolStripMenuItem.Text = "Normalizator Tagów";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(264, 6);
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            this.opcjeToolStripMenuItem.Click += new System.EventHandler(this.opcjeToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktualizacjeToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aktualizacjeToolStripMenuItem
            // 
            this.aktualizacjeToolStripMenuItem.Name = "aktualizacjeToolStripMenuItem";
            this.aktualizacjeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.aktualizacjeToolStripMenuItem.Text = "Aktualizacje...";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.oProgramieToolStripMenuItem.Text = "O Programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indeksPomocyToolStripMenuItem,
            this.fAQToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // indeksPomocyToolStripMenuItem
            // 
            this.indeksPomocyToolStripMenuItem.Name = "indeksPomocyToolStripMenuItem";
            this.indeksPomocyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.indeksPomocyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.indeksPomocyToolStripMenuItem.Text = "Indeks Pomocy";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*.mp3|*.MP3";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1048, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1048, 650);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearTableBut);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "TagMainWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Button addDirBut;
        private System.Windows.Forms.DataGridView mainGrid;
        private System.Windows.Forms.Button clearTableBut;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem właściwościToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzPlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narzędziaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktualizacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indeksPomocyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem szablonyTagówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalizatorToolStripMenuItem;
        private System.Windows.Forms.Label isFilePathGiven;
        private System.Windows.Forms.CheckBox ifSubfolders;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Track;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Composer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;

    }
}

