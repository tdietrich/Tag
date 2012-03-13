namespace TagApp
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filesListingrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.isFilePathGiven = new System.Windows.Forms.Label();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.addDirBut = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FileOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileTagType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearTableBut = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.właściwościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dodajNowySzablonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujSzablonyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualizacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indeksPomocyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.filesListingrichTextBox1);
            this.groupBox1.Controls.Add(this.isFilePathGiven);
            this.groupBox1.Controls.Add(this.directoryTextBox);
            this.groupBox1.Controls.Add(this.addDirBut);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ładowanie Folderu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pliki mp3 w Folderze";
            // 
            // filesListingrichTextBox1
            // 
            this.filesListingrichTextBox1.AutoWordSelection = true;
            this.filesListingrichTextBox1.Location = new System.Drawing.Point(6, 188);
            this.filesListingrichTextBox1.Name = "filesListingrichTextBox1";
            this.filesListingrichTextBox1.ReadOnly = true;
            this.filesListingrichTextBox1.Size = new System.Drawing.Size(230, 165);
            this.filesListingrichTextBox1.TabIndex = 6;
            this.filesListingrichTextBox1.Text = "";
            // 
            // isFilePathGiven
            // 
            this.isFilePathGiven.AutoSize = true;
            this.isFilePathGiven.Location = new System.Drawing.Point(7, 113);
            this.isFilePathGiven.Name = "isFilePathGiven";
            this.isFilePathGiven.Size = new System.Drawing.Size(66, 13);
            this.isFilePathGiven.TabIndex = 2;
            this.isFilePathGiven.Text = "Brak Ścieżki";
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(7, 37);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(230, 20);
            this.directoryTextBox.TabIndex = 1;
            // 
            // addDirBut
            // 
            this.addDirBut.Location = new System.Drawing.Point(162, 74);
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
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(261, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 529);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Szczegóły Plików";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileOrderNumber,
            this.FileName,
            this.FileTagType,
            this.FileArtist,
            this.FileNum,
            this.FileTitle,
            this.FilePath});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 490);
            this.dataGridView1.TabIndex = 0;
            // 
            // FileOrderNumber
            // 
            this.FileOrderNumber.Frozen = true;
            this.FileOrderNumber.HeaderText = "L.p";
            this.FileOrderNumber.Name = "FileOrderNumber";
            this.FileOrderNumber.ReadOnly = true;
            this.FileOrderNumber.Width = 25;
            // 
            // FileName
            // 
            this.FileName.Frozen = true;
            this.FileName.HeaderText = "Nazwa";
            this.FileName.Name = "FileName";
            // 
            // FileTagType
            // 
            this.FileTagType.HeaderText = "Rodzaj Tagów";
            this.FileTagType.Name = "FileTagType";
            this.FileTagType.Width = 50;
            // 
            // FileArtist
            // 
            this.FileArtist.HeaderText = "Wykonawca";
            this.FileArtist.Name = "FileArtist";
            // 
            // FileNum
            // 
            this.FileNum.HeaderText = "Nr";
            this.FileNum.Name = "FileNum";
            // 
            // FileTitle
            // 
            this.FileTitle.HeaderText = "Tytuł";
            this.FileTitle.Name = "FileTitle";
            // 
            // FilePath
            // 
            this.FilePath.HeaderText = "Ścieżka";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            // 
            // clearTableBut
            // 
            this.clearTableBut.Location = new System.Drawing.Point(883, 566);
            this.clearTableBut.Name = "clearTableBut";
            this.clearTableBut.Size = new System.Drawing.Size(153, 23);
            this.clearTableBut.TabIndex = 2;
            this.clearTableBut.Text = "Wyczyść tabelę";
            this.clearTableBut.UseVisualStyleBackColor = true;
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 592);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1048, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "Brak Zadań";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
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
            this.normalizatorToolStripMenuItem});
            this.narzędziaToolStripMenuItem.Name = "narzędziaToolStripMenuItem";
            this.narzędziaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narzędziaToolStripMenuItem.Text = "Narzędzia";
            // 
            // szablonyTagówToolStripMenuItem
            // 
            this.szablonyTagówToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNowySzablonToolStripMenuItem,
            this.edytujSzablonyToolStripMenuItem});
            this.szablonyTagówToolStripMenuItem.Name = "szablonyTagówToolStripMenuItem";
            this.szablonyTagówToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.szablonyTagówToolStripMenuItem.Text = "Szablony Nazewnictwa";
            // 
            // dodajNowySzablonToolStripMenuItem
            // 
            this.dodajNowySzablonToolStripMenuItem.Name = "dodajNowySzablonToolStripMenuItem";
            this.dodajNowySzablonToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.dodajNowySzablonToolStripMenuItem.Text = "Dodaj Nowy Szablon";
            // 
            // edytujSzablonyToolStripMenuItem
            // 
            this.edytujSzablonyToolStripMenuItem.Enabled = false;
            this.edytujSzablonyToolStripMenuItem.Name = "edytujSzablonyToolStripMenuItem";
            this.edytujSzablonyToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.edytujSzablonyToolStripMenuItem.Text = "Edytuj Istniejace Szablony";
            // 
            // normalizatorToolStripMenuItem
            // 
            this.normalizatorToolStripMenuItem.Name = "normalizatorToolStripMenuItem";
            this.normalizatorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.normalizatorToolStripMenuItem.Text = "Normalizator Tagów";
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
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1048, 614);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clearTableBut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TagMainWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Button addDirBut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clearTableBut;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem właściwościToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn FileOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileTagType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem szablonyTagówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNowySzablonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujSzablonyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalizatorToolStripMenuItem;
        private System.Windows.Forms.Label isFilePathGiven;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox filesListingrichTextBox1;

    }
}

