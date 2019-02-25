namespace StructuredReaderWV
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadStructuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveStructuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.endianessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.littleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.rtb1 = new System.Windows.Forms.RichTextBox();
			this.hb1 = new Be.Windows.Forms.HexBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rtb2 = new System.Windows.Forms.RichTextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.status = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.endianessToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1050, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadBinaryToolStripMenuItem,
            this.loadStructuresToolStripMenuItem,
            this.saveStructuresToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loadBinaryToolStripMenuItem
			// 
			this.loadBinaryToolStripMenuItem.Name = "loadBinaryToolStripMenuItem";
			this.loadBinaryToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.loadBinaryToolStripMenuItem.Text = "Load Binary...";
			this.loadBinaryToolStripMenuItem.Click += new System.EventHandler(this.loadBinaryToolStripMenuItem_Click);
			// 
			// loadStructuresToolStripMenuItem
			// 
			this.loadStructuresToolStripMenuItem.Name = "loadStructuresToolStripMenuItem";
			this.loadStructuresToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.loadStructuresToolStripMenuItem.Text = "Load Structures...";
			this.loadStructuresToolStripMenuItem.Click += new System.EventHandler(this.loadStructuresToolStripMenuItem_Click);
			// 
			// saveStructuresToolStripMenuItem
			// 
			this.saveStructuresToolStripMenuItem.Name = "saveStructuresToolStripMenuItem";
			this.saveStructuresToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.saveStructuresToolStripMenuItem.Text = "Save Structures...";
			this.saveStructuresToolStripMenuItem.Click += new System.EventHandler(this.saveStructuresToolStripMenuItem_Click);
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// endianessToolStripMenuItem
			// 
			this.endianessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.littleToolStripMenuItem,
            this.bigToolStripMenuItem});
			this.endianessToolStripMenuItem.Name = "endianessToolStripMenuItem";
			this.endianessToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.endianessToolStripMenuItem.Text = "Endianess";
			// 
			// littleToolStripMenuItem
			// 
			this.littleToolStripMenuItem.Checked = true;
			this.littleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.littleToolStripMenuItem.Name = "littleToolStripMenuItem";
			this.littleToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.littleToolStripMenuItem.Text = "Little";
			this.littleToolStripMenuItem.Click += new System.EventHandler(this.littleToolStripMenuItem_Click);
			// 
			// bigToolStripMenuItem
			// 
			this.bigToolStripMenuItem.Name = "bigToolStripMenuItem";
			this.bigToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.bigToolStripMenuItem.Text = "Big";
			this.bigToolStripMenuItem.Click += new System.EventHandler(this.bigToolStripMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.rtb2);
			this.splitContainer1.Size = new System.Drawing.Size(1050, 571);
			this.splitContainer1.SplitterDistance = 642;
			this.splitContainer1.TabIndex = 1;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.rtb1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.hb1);
			this.splitContainer2.Panel2.Controls.Add(this.label1);
			this.splitContainer2.Size = new System.Drawing.Size(642, 571);
			this.splitContainer2.SplitterDistance = 333;
			this.splitContainer2.TabIndex = 0;
			// 
			// rtb1
			// 
			this.rtb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtb1.DetectUrls = false;
			this.rtb1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb1.Font = new System.Drawing.Font("Courier New", 10F);
			this.rtb1.Location = new System.Drawing.Point(0, 0);
			this.rtb1.Name = "rtb1";
			this.rtb1.Size = new System.Drawing.Size(642, 333);
			this.rtb1.TabIndex = 0;
			this.rtb1.Text = "struct substruct\n{\n int test1;\n int test2;\n}\n\nstruct main{\n int test1;\n float tes" +
    "t2;\n dword test3;\n byte test4[10];\n substruct test5;\n}";
			this.rtb1.WordWrap = false;
			// 
			// hb1
			// 
			this.hb1.BoldFont = null;
			this.hb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.hb1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hb1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hb1.LineInfoForeColor = System.Drawing.Color.Empty;
			this.hb1.LineInfoVisible = true;
			this.hb1.Location = new System.Drawing.Point(0, 24);
			this.hb1.Name = "hb1";
			this.hb1.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
			this.hb1.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
			this.hb1.Size = new System.Drawing.Size(642, 210);
			this.hb1.StringViewVisible = true;
			this.hb1.TabIndex = 0;
			this.hb1.UseFixedBytesPerLine = true;
			this.hb1.VScrollBarVisible = true;
			this.hb1.CurrentLineChanged += new System.EventHandler(this.hb1_CurrentLineChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Courier New", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
			this.label1.Size = new System.Drawing.Size(642, 24);
			this.label1.TabIndex = 0;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rtb2
			// 
			this.rtb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtb2.DetectUrls = false;
			this.rtb2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb2.Font = new System.Drawing.Font("Courier New", 10F);
			this.rtb2.Location = new System.Drawing.Point(0, 0);
			this.rtb2.Name = "rtb2";
			this.rtb2.Size = new System.Drawing.Size(404, 571);
			this.rtb2.TabIndex = 1;
			this.rtb2.Text = "";
			this.rtb2.WordWrap = false;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
			this.statusStrip1.Location = new System.Drawing.Point(0, 595);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1050, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// status
			// 
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(0, 17);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1050, 617);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.statusStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Structured Reader by Warranty Voider";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.RichTextBox rtb2;
        private System.Windows.Forms.ToolStripMenuItem loadBinaryToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadStructuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStructuresToolStripMenuItem;
        private Be.Windows.Forms.HexBox hb1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripMenuItem endianessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem littleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigToolStripMenuItem;
		private System.Windows.Forms.Label label1;
	}
}

