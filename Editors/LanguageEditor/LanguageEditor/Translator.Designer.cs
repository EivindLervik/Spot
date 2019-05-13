namespace LanguageEditor
{
    partial class Translator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Translator));
            this.mainMenu_ms = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folder_fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.workingDirectory_wd = new System.Windows.Forms.Label();
            this.workingDirectory_te = new System.Windows.Forms.TextBox();
            this.windowContent_panel = new System.Windows.Forms.Panel();
            this.languageBox_cb = new System.Windows.Forms.ComboBox();
            this.keyList_lb = new System.Windows.Forms.ListBox();
            this.file_label = new System.Windows.Forms.Label();
            this.languageKeyText_tb = new System.Windows.Forms.TextBox();
            this.text_label = new System.Windows.Forms.Label();
            this.english_label = new System.Windows.Forms.Label();
            this.english_tb = new System.Windows.Forms.TextBox();
            this.mainMenu_ms.SuspendLayout();
            this.windowContent_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu_ms
            // 
            this.mainMenu_ms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu_ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.viewToolStripMenuItem});
            this.mainMenu_ms.Location = new System.Drawing.Point(0, 0);
            this.mainMenu_ms.Name = "mainMenu_ms";
            this.mainMenu_ms.Size = new System.Drawing.Size(730, 28);
            this.mainMenu_ms.TabIndex = 5;
            this.mainMenu_ms.Text = "mainMenu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developerToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.developerToolStripMenuItem.Text = "Developer";
            this.developerToolStripMenuItem.Click += new System.EventHandler(this.developerToolStripMenuItem_Click);
            // 
            // workingDirectory_wd
            // 
            this.workingDirectory_wd.AutoSize = true;
            this.workingDirectory_wd.Location = new System.Drawing.Point(3, 6);
            this.workingDirectory_wd.Name = "workingDirectory_wd";
            this.workingDirectory_wd.Size = new System.Drawing.Size(125, 17);
            this.workingDirectory_wd.TabIndex = 6;
            this.workingDirectory_wd.Text = "Working Directory:";
            // 
            // workingDirectory_te
            // 
            this.workingDirectory_te.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workingDirectory_te.Location = new System.Drawing.Point(134, 3);
            this.workingDirectory_te.Name = "workingDirectory_te";
            this.workingDirectory_te.ReadOnly = true;
            this.workingDirectory_te.Size = new System.Drawing.Size(569, 22);
            this.workingDirectory_te.TabIndex = 7;
            // 
            // windowContent_panel
            // 
            this.windowContent_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowContent_panel.Controls.Add(this.english_label);
            this.windowContent_panel.Controls.Add(this.text_label);
            this.windowContent_panel.Controls.Add(this.english_tb);
            this.windowContent_panel.Controls.Add(this.languageKeyText_tb);
            this.windowContent_panel.Controls.Add(this.file_label);
            this.windowContent_panel.Controls.Add(this.keyList_lb);
            this.windowContent_panel.Controls.Add(this.languageBox_cb);
            this.windowContent_panel.Controls.Add(this.workingDirectory_te);
            this.windowContent_panel.Controls.Add(this.workingDirectory_wd);
            this.windowContent_panel.Location = new System.Drawing.Point(12, 31);
            this.windowContent_panel.Name = "windowContent_panel";
            this.windowContent_panel.Size = new System.Drawing.Size(706, 400);
            this.windowContent_panel.TabIndex = 8;
            // 
            // languageBox_cb
            // 
            this.languageBox_cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languageBox_cb.FormattingEnabled = true;
            this.languageBox_cb.Location = new System.Drawing.Point(513, 33);
            this.languageBox_cb.Name = "languageBox_cb";
            this.languageBox_cb.Size = new System.Drawing.Size(190, 24);
            this.languageBox_cb.TabIndex = 9;
            this.languageBox_cb.SelectedIndexChanged += new System.EventHandler(this.languageBox_cb_SelectedIndexChanged);
            // 
            // keyList_lb
            // 
            this.keyList_lb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.keyList_lb.FormattingEnabled = true;
            this.keyList_lb.ItemHeight = 16;
            this.keyList_lb.Location = new System.Drawing.Point(3, 31);
            this.keyList_lb.Name = "keyList_lb";
            this.keyList_lb.Size = new System.Drawing.Size(371, 356);
            this.keyList_lb.TabIndex = 10;
            this.keyList_lb.SelectedIndexChanged += new System.EventHandler(this.keyList_lb_SelectedIndexChanged);
            // 
            // file_label
            // 
            this.file_label.AutoSize = true;
            this.file_label.Location = new System.Drawing.Point(380, 36);
            this.file_label.Name = "file_label";
            this.file_label.Size = new System.Drawing.Size(127, 17);
            this.file_label.TabIndex = 12;
            this.file_label.Text = "Current Language:";
            // 
            // languageKeyText_tb
            // 
            this.languageKeyText_tb.Location = new System.Drawing.Point(513, 163);
            this.languageKeyText_tb.Multiline = true;
            this.languageKeyText_tb.Name = "languageKeyText_tb";
            this.languageKeyText_tb.Size = new System.Drawing.Size(190, 224);
            this.languageKeyText_tb.TabIndex = 13;
            this.languageKeyText_tb.TextChanged += new System.EventHandler(this.languageKeyText_tb_TextChanged);
            // 
            // text_label
            // 
            this.text_label.AutoSize = true;
            this.text_label.Location = new System.Drawing.Point(468, 166);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(39, 17);
            this.text_label.TabIndex = 14;
            this.text_label.Text = "Text:";
            // 
            // english_label
            // 
            this.english_label.AutoSize = true;
            this.english_label.Location = new System.Drawing.Point(449, 66);
            this.english_label.Name = "english_label";
            this.english_label.Size = new System.Drawing.Size(58, 17);
            this.english_label.TabIndex = 14;
            this.english_label.Text = "English:";
            // 
            // english_tb
            // 
            this.english_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.english_tb.Location = new System.Drawing.Point(513, 63);
            this.english_tb.Multiline = true;
            this.english_tb.Name = "english_tb";
            this.english_tb.ReadOnly = true;
            this.english_tb.Size = new System.Drawing.Size(190, 94);
            this.english_tb.TabIndex = 13;
            // 
            // Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 443);
            this.Controls.Add(this.windowContent_panel);
            this.Controls.Add(this.mainMenu_ms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu_ms;
            this.Name = "Translator";
            this.Text = "Translator";
            this.mainMenu_ms.ResumeLayout(false);
            this.mainMenu_ms.PerformLayout();
            this.windowContent_panel.ResumeLayout(false);
            this.windowContent_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenu_ms;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folder_fbd;
        private System.Windows.Forms.Label workingDirectory_wd;
        private System.Windows.Forms.TextBox workingDirectory_te;
        private System.Windows.Forms.Panel windowContent_panel;
        private System.Windows.Forms.ComboBox languageBox_cb;
        private System.Windows.Forms.Label text_label;
        private System.Windows.Forms.TextBox languageKeyText_tb;
        private System.Windows.Forms.Label file_label;
        private System.Windows.Forms.ListBox keyList_lb;
        private System.Windows.Forms.Label english_label;
        private System.Windows.Forms.TextBox english_tb;
    }
}

