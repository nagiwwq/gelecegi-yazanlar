namespace Loginislemleri
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
            this.BtnFolderBrowser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnSaveDialog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TxtBelgeAdi = new System.Windows.Forms.Label();
            this.TxtYol = new System.Windows.Forms.TextBox();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.BtnKonum = new System.Windows.Forms.Button();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnOku = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFolderBrowser
            // 
            this.BtnFolderBrowser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnFolderBrowser.Location = new System.Drawing.Point(349, 12);
            this.BtnFolderBrowser.Name = "BtnFolderBrowser";
            this.BtnFolderBrowser.Size = new System.Drawing.Size(124, 35);
            this.BtnFolderBrowser.TabIndex = 0;
            this.BtnFolderBrowser.Text = "Folder Browser Dialog";
            this.BtnFolderBrowser.UseVisualStyleBackColor = false;
            this.BtnFolderBrowser.Click += new System.EventHandler(this.BtnFolderBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnOpenFile.Location = new System.Drawing.Point(349, 53);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(124, 35);
            this.BtnOpenFile.TabIndex = 2;
            this.BtnOpenFile.Text = "Open File Dialog";
            this.BtnOpenFile.UseVisualStyleBackColor = false;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnSaveDialog
            // 
            this.BtnSaveDialog.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnSaveDialog.Location = new System.Drawing.Point(349, 94);
            this.BtnSaveDialog.Name = "BtnSaveDialog";
            this.BtnSaveDialog.Size = new System.Drawing.Size(124, 35);
            this.BtnSaveDialog.TabIndex = 3;
            this.BtnSaveDialog.Text = "Save File Dialog";
            this.BtnSaveDialog.UseVisualStyleBackColor = false;
            this.BtnSaveDialog.Click += new System.EventHandler(this.BtnSaveDialog_Click);
            // 
            // TxtBelgeAdi
            // 
            this.TxtBelgeAdi.AutoSize = true;
            this.TxtBelgeAdi.Location = new System.Drawing.Point(29, 23);
            this.TxtBelgeAdi.Name = "TxtBelgeAdi";
            this.TxtBelgeAdi.Size = new System.Drawing.Size(59, 13);
            this.TxtBelgeAdi.TabIndex = 4;
            this.TxtBelgeAdi.Text = "Belge yolu:";
            // 
            // TxtYol
            // 
            this.TxtYol.Location = new System.Drawing.Point(103, 20);
            this.TxtYol.Name = "TxtYol";
            this.TxtYol.Size = new System.Drawing.Size(155, 20);
            this.TxtYol.TabIndex = 5;
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnOlustur.Location = new System.Drawing.Point(349, 176);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(124, 35);
            this.BtnOlustur.TabIndex = 7;
            this.BtnOlustur.Text = "Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = false;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // BtnKonum
            // 
            this.BtnKonum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnKonum.Location = new System.Drawing.Point(349, 135);
            this.BtnKonum.Name = "BtnKonum";
            this.BtnKonum.Size = new System.Drawing.Size(124, 35);
            this.BtnKonum.TabIndex = 6;
            this.BtnKonum.Text = "Konum seç";
            this.BtnKonum.UseVisualStyleBackColor = false;
            this.BtnKonum.Click += new System.EventHandler(this.BtnKonum_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(103, 57);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(155, 20);
            this.TxtAd.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Belge adı:";
            // 
            // BtnOku
            // 
            this.BtnOku.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnOku.Location = new System.Drawing.Point(349, 217);
            this.BtnOku.Name = "BtnOku";
            this.BtnOku.Size = new System.Drawing.Size(124, 35);
            this.BtnOku.TabIndex = 10;
            this.BtnOku.Text = "Oku";
            this.BtnOku.UseVisualStyleBackColor = false;
            this.BtnOku.Click += new System.EventHandler(this.BtnOku_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(32, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 43);
            this.listBox1.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 156);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(226, 157);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnYazdir.Location = new System.Drawing.Point(349, 258);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(124, 35);
            this.BtnYazdir.TabIndex = 13;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = false;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(508, 384);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnOku);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnOlustur);
            this.Controls.Add(this.BtnKonum);
            this.Controls.Add(this.TxtYol);
            this.Controls.Add(this.TxtBelgeAdi);
            this.Controls.Add(this.BtnSaveDialog);
            this.Controls.Add(this.BtnOpenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFolderBrowser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFolderBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnSaveDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label TxtBelgeAdi;
        private System.Windows.Forms.TextBox TxtYol;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.Button BtnKonum;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnOku;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnYazdir;
    }
}

