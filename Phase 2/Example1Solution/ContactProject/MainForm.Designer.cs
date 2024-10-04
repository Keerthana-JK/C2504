namespace ContactProject
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.txtEditor = new System.Windows.Forms.TextBox();
			this.mnuEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuRed2 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuBlue2 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuGreen2 = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.stsForeColor = new System.Windows.Forms.StatusStrip();
			this.btnPickColor = new System.Windows.Forms.Button();
			this.lblForeground = new System.Windows.Forms.Label();
			this.btnMoreColors = new System.Windows.Forms.Button();
			this.btnGreen = new System.Windows.Forms.Button();
			this.btnBlue = new System.Windows.Forms.Button();
			this.btnRed = new System.Windows.Forms.Button();
			this.dlgColor = new System.Windows.Forms.ColorDialog();
			this.stsPage = new System.Windows.Forms.StatusStrip();
			this.stsColor = new System.Windows.Forms.ToolStripStatusLabel();
			this.stsForegroundColor = new System.Windows.Forms.ToolStripStatusLabel();
			this.mnuBar = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRedBG = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuBlueBG = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuGreenBG = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuBG = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFG = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuAlignLeft = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAlignCenter = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAlignRight = new System.Windows.Forms.ToolStripMenuItem();
			this.dlgFont = new System.Windows.Forms.FontDialog();
			this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
			this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
			this.dlgSave = new System.Windows.Forms.SaveFileDialog();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbAlignLeft = new System.Windows.Forms.ToolStripButton();
			this.tsbAlignCenter = new System.Windows.Forms.ToolStripButton();
			this.tsbAlignRight = new System.Windows.Forms.ToolStripButton();
			this.mnuEditor.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			this.stsPage.SuspendLayout();
			this.mnuBar.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Gold;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(800, 73);
			this.label1.TabIndex = 0;
			this.label1.Text = "Editor App";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtEditor
			// 
			this.txtEditor.BackColor = System.Drawing.Color.PaleTurquoise;
			this.txtEditor.ContextMenuStrip = this.mnuEditor;
			this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtEditor.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEditor.Location = new System.Drawing.Point(0, 134);
			this.txtEditor.Multiline = true;
			this.txtEditor.Name = "txtEditor";
			this.txtEditor.Size = new System.Drawing.Size(800, 483);
			this.txtEditor.TabIndex = 1;
			this.txtEditor.Text = "I am Keerthana\r\nIntern in Quest Global\r\n";
			// 
			// mnuEditor
			// 
			this.mnuEditor.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRed2,
            this.mnuBlue2,
            this.mnuGreen2});
			this.mnuEditor.Name = "mnuEditor";
			this.mnuEditor.Size = new System.Drawing.Size(241, 76);
			// 
			// mnuRed2
			// 
			this.mnuRed2.Name = "mnuRed2";
			this.mnuRed2.Size = new System.Drawing.Size(240, 24);
			this.mnuRed2.Text = "Red Background Color";
			this.mnuRed2.Click += new System.EventHandler(this.mnuRed2_Click);
			// 
			// mnuBlue2
			// 
			this.mnuBlue2.Name = "mnuBlue2";
			this.mnuBlue2.Size = new System.Drawing.Size(240, 24);
			this.mnuBlue2.Text = "Blue Background Color";
			this.mnuBlue2.Click += new System.EventHandler(this.mnuBlue2_Click);
			// 
			// mnuGreen2
			// 
			this.mnuGreen2.Name = "mnuGreen2";
			this.mnuGreen2.Size = new System.Drawing.Size(240, 24);
			this.mnuGreen2.Text = "Green Background Color";
			this.mnuGreen2.Click += new System.EventHandler(this.mnuGreen2_Click);
			// 
			// pnlBottom
			// 
			this.pnlBottom.Controls.Add(this.stsForeColor);
			this.pnlBottom.Controls.Add(this.btnPickColor);
			this.pnlBottom.Controls.Add(this.lblForeground);
			this.pnlBottom.Controls.Add(this.btnMoreColors);
			this.pnlBottom.Controls.Add(this.btnGreen);
			this.pnlBottom.Controls.Add(this.btnBlue);
			this.pnlBottom.Controls.Add(this.btnRed);
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 479);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(800, 138);
			this.pnlBottom.TabIndex = 2;
			// 
			// stsForeColor
			// 
			this.stsForeColor.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.stsForeColor.Location = new System.Drawing.Point(0, 116);
			this.stsForeColor.Name = "stsForeColor";
			this.stsForeColor.Size = new System.Drawing.Size(800, 22);
			this.stsForeColor.TabIndex = 6;
			this.stsForeColor.Text = "statusStrip1";
			// 
			// btnPickColor
			// 
			this.btnPickColor.Location = new System.Drawing.Point(571, 31);
			this.btnPickColor.Name = "btnPickColor";
			this.btnPickColor.Size = new System.Drawing.Size(94, 24);
			this.btnPickColor.TabIndex = 5;
			this.btnPickColor.Text = "Pick Color";
			this.btnPickColor.UseVisualStyleBackColor = true;
			this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
			// 
			// lblForeground
			// 
			this.lblForeground.AutoSize = true;
			this.lblForeground.Location = new System.Drawing.Point(578, 12);
			this.lblForeground.Name = "lblForeground";
			this.lblForeground.Size = new System.Drawing.Size(77, 16);
			this.lblForeground.TabIndex = 4;
			this.lblForeground.Text = "Foreground";
			// 
			// btnMoreColors
			// 
			this.btnMoreColors.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMoreColors.Location = new System.Drawing.Point(436, 20);
			this.btnMoreColors.Name = "btnMoreColors";
			this.btnMoreColors.Size = new System.Drawing.Size(103, 46);
			this.btnMoreColors.TabIndex = 3;
			this.btnMoreColors.Text = "...";
			this.btnMoreColors.UseVisualStyleBackColor = true;
			this.btnMoreColors.Click += new System.EventHandler(this.btnMoreColors_Click);
			// 
			// btnGreen
			// 
			this.btnGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnGreen.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGreen.Location = new System.Drawing.Point(291, 19);
			this.btnGreen.Name = "btnGreen";
			this.btnGreen.Size = new System.Drawing.Size(115, 48);
			this.btnGreen.TabIndex = 2;
			this.btnGreen.Text = "Green";
			this.btnGreen.UseVisualStyleBackColor = false;
			this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
			// 
			// btnBlue
			// 
			this.btnBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnBlue.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBlue.Location = new System.Drawing.Point(150, 19);
			this.btnBlue.Name = "btnBlue";
			this.btnBlue.Size = new System.Drawing.Size(115, 48);
			this.btnBlue.TabIndex = 1;
			this.btnBlue.Text = "Blue";
			this.btnBlue.UseVisualStyleBackColor = false;
			this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
			// 
			// btnRed
			// 
			this.btnRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnRed.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRed.Location = new System.Drawing.Point(11, 19);
			this.btnRed.Name = "btnRed";
			this.btnRed.Size = new System.Drawing.Size(115, 48);
			this.btnRed.TabIndex = 0;
			this.btnRed.Text = "Red";
			this.btnRed.UseVisualStyleBackColor = false;
			this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
			// 
			// stsPage
			// 
			this.stsPage.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.stsPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsColor,
            this.stsForegroundColor});
			this.stsPage.Location = new System.Drawing.Point(0, 453);
			this.stsPage.Name = "stsPage";
			this.stsPage.Size = new System.Drawing.Size(800, 26);
			this.stsPage.TabIndex = 3;
			this.stsPage.Text = "statusStrip1";
			// 
			// stsColor
			// 
			this.stsColor.Name = "stsColor";
			this.stsColor.Size = new System.Drawing.Size(128, 20);
			this.stsColor.Text = "Background Color";
			// 
			// stsForegroundColor
			// 
			this.stsForegroundColor.Name = "stsForegroundColor";
			this.stsForegroundColor.Size = new System.Drawing.Size(126, 20);
			this.stsForegroundColor.Text = "Foreground Color";
			// 
			// mnuBar
			// 
			this.mnuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuColor,
            this.mnuFormat});
			this.mnuBar.Location = new System.Drawing.Point(0, 0);
			this.mnuBar.Name = "mnuBar";
			this.mnuBar.Size = new System.Drawing.Size(800, 30);
			this.mnuBar.TabIndex = 4;
			this.mnuBar.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.toolStripSeparator3,
            this.mnuSave});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(46, 24);
			this.mnuFile.Text = "File";
			// 
			// mnuColor
			// 
			this.mnuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRedBG,
            this.mnuBlueBG,
            this.mnuGreenBG,
            this.mnuBG,
            this.toolStripSeparator1,
            this.mnuFG});
			this.mnuColor.Name = "mnuColor";
			this.mnuColor.Size = new System.Drawing.Size(59, 24);
			this.mnuColor.Text = "Color";
			// 
			// mnuRedBG
			// 
			this.mnuRedBG.Name = "mnuRedBG";
			this.mnuRedBG.Size = new System.Drawing.Size(254, 26);
			this.mnuRedBG.Text = "Red Background Color";
			this.mnuRedBG.Click += new System.EventHandler(this.mnuRedBG_Click);
			// 
			// mnuBlueBG
			// 
			this.mnuBlueBG.Name = "mnuBlueBG";
			this.mnuBlueBG.Size = new System.Drawing.Size(254, 26);
			this.mnuBlueBG.Text = "Blue Background Color";
			this.mnuBlueBG.Click += new System.EventHandler(this.mnuBlueBG_Click);
			// 
			// mnuGreenBG
			// 
			this.mnuGreenBG.Name = "mnuGreenBG";
			this.mnuGreenBG.Size = new System.Drawing.Size(254, 26);
			this.mnuGreenBG.Text = "Green Background Color";
			this.mnuGreenBG.Click += new System.EventHandler(this.mnuGreenBG_Click);
			// 
			// mnuBG
			// 
			this.mnuBG.Name = "mnuBG";
			this.mnuBG.Size = new System.Drawing.Size(254, 26);
			this.mnuBG.Text = "Other Background Color";
			this.mnuBG.Click += new System.EventHandler(this.mnuBG_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
			// 
			// mnuFG
			// 
			this.mnuFG.Name = "mnuFG";
			this.mnuFG.Size = new System.Drawing.Size(254, 26);
			this.mnuFG.Text = "Foreground Color...";
			this.mnuFG.Click += new System.EventHandler(this.mnuFG_Click);
			// 
			// mnuFormat
			// 
			this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFont,
            this.toolStripSeparator2,
            this.mnuAlignLeft,
            this.mnuAlignCenter,
            this.mnuAlignRight});
			this.mnuFormat.Name = "mnuFormat";
			this.mnuFormat.Size = new System.Drawing.Size(70, 24);
			this.mnuFormat.Text = "Format";
			// 
			// mnuFont
			// 
			this.mnuFont.Name = "mnuFont";
			this.mnuFont.Size = new System.Drawing.Size(174, 26);
			this.mnuFont.Text = "Font...";
			this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
			// 
			// mnuAlignLeft
			// 
			this.mnuAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("mnuAlignLeft.Image")));
			this.mnuAlignLeft.Name = "mnuAlignLeft";
			this.mnuAlignLeft.Size = new System.Drawing.Size(174, 26);
			this.mnuAlignLeft.Text = "Align Left";
			this.mnuAlignLeft.Click += new System.EventHandler(this.mnuAlignLeft_Click);
			// 
			// mnuAlignCenter
			// 
			this.mnuAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("mnuAlignCenter.Image")));
			this.mnuAlignCenter.Name = "mnuAlignCenter";
			this.mnuAlignCenter.Size = new System.Drawing.Size(174, 26);
			this.mnuAlignCenter.Text = "Align Center";
			this.mnuAlignCenter.Click += new System.EventHandler(this.mnuAlignCenter_Click);
			// 
			// mnuAlignRight
			// 
			this.mnuAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("mnuAlignRight.Image")));
			this.mnuAlignRight.Name = "mnuAlignRight";
			this.mnuAlignRight.Size = new System.Drawing.Size(174, 26);
			this.mnuAlignRight.Text = "Align Right";
			this.mnuAlignRight.Click += new System.EventHandler(this.mnuAlignRight_Click);
			// 
			// mnuOpen
			// 
			this.mnuOpen.Name = "mnuOpen";
			this.mnuOpen.Size = new System.Drawing.Size(224, 26);
			this.mnuOpen.Text = "Open...";
			this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
			// 
			// mnuSave
			// 
			this.mnuSave.Name = "mnuSave";
			this.mnuSave.Size = new System.Drawing.Size(224, 26);
			this.mnuSave.Text = "Save...";
			this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
			// 
			// dlgOpen
			// 
			this.dlgOpen.FileName = "mytext";
			// 
			// dlgSave
			// 
			this.dlgSave.FileName = "mytext.txt";
			this.dlgSave.Filter = "Text File(*.txt) | JSON File (*.json)";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAlignLeft,
            this.tsbAlignCenter,
            this.tsbAlignRight});
			this.toolStrip1.Location = new System.Drawing.Point(0, 30);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 31);
			this.toolStrip1.TabIndex = 5;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbAlignLeft
			// 
			this.tsbAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlignLeft.Image")));
			this.tsbAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAlignLeft.Name = "tsbAlignLeft";
			this.tsbAlignLeft.Size = new System.Drawing.Size(29, 24);
			this.tsbAlignLeft.Text = "toolStripButton1";
			this.tsbAlignLeft.Click += new System.EventHandler(this.tsbAlignLeft_Click);
			// 
			// tsbAlignCenter
			// 
			this.tsbAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlignCenter.Image")));
			this.tsbAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAlignCenter.Name = "tsbAlignCenter";
			this.tsbAlignCenter.Size = new System.Drawing.Size(29, 24);
			this.tsbAlignCenter.Text = "toolStripButton2";
			this.tsbAlignCenter.Click += new System.EventHandler(this.tsbAlignCenter_Click);
			// 
			// tsbAlignRight
			// 
			this.tsbAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlignRight.Image")));
			this.tsbAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAlignRight.Name = "tsbAlignRight";
			this.tsbAlignRight.Size = new System.Drawing.Size(29, 24);
			this.tsbAlignRight.Text = "toolStripButton3";
			this.tsbAlignRight.Click += new System.EventHandler(this.tsbAlignRight_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 617);
			this.Controls.Add(this.stsPage);
			this.Controls.Add(this.pnlBottom);
			this.Controls.Add(this.txtEditor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.mnuBar);
			this.Name = "Form1";
			this.Text = "Editor App";
			this.mnuEditor.ResumeLayout(false);
			this.pnlBottom.ResumeLayout(false);
			this.pnlBottom.PerformLayout();
			this.stsPage.ResumeLayout(false);
			this.stsPage.PerformLayout();
			this.mnuBar.ResumeLayout(false);
			this.mnuBar.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEditor;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Button btnGreen;
		private System.Windows.Forms.Button btnBlue;
		private System.Windows.Forms.Button btnRed;
		private System.Windows.Forms.Button btnMoreColors;
		private System.Windows.Forms.ColorDialog dlgColor;
		private System.Windows.Forms.StatusStrip stsPage;
		private System.Windows.Forms.ToolStripStatusLabel stsColor;
		private System.Windows.Forms.Label lblForeground;
		private System.Windows.Forms.Button btnPickColor;
		private System.Windows.Forms.StatusStrip stsForeColor;
		private System.Windows.Forms.ToolStripStatusLabel stsForegroundColor;
		private System.Windows.Forms.MenuStrip mnuBar;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.ToolStripMenuItem mnuColor;
		private System.Windows.Forms.ToolStripMenuItem mnuRedBG;
		private System.Windows.Forms.ToolStripMenuItem mnuBlueBG;
		private System.Windows.Forms.ToolStripMenuItem mnuGreenBG;
		private System.Windows.Forms.ToolStripMenuItem mnuBG;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnuFG;
		private System.Windows.Forms.ContextMenuStrip mnuEditor;
		private System.Windows.Forms.ToolStripMenuItem mnuRed2;
		private System.Windows.Forms.ToolStripMenuItem mnuBlue2;
		private System.Windows.Forms.ToolStripMenuItem mnuGreen2;
		private System.Windows.Forms.ToolStripMenuItem mnuFormat;
		private System.Windows.Forms.ToolStripMenuItem mnuFont;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem mnuAlignLeft;
		private System.Windows.Forms.ToolStripMenuItem mnuAlignCenter;
		private System.Windows.Forms.ToolStripMenuItem mnuAlignRight;
		private System.Windows.Forms.FontDialog dlgFont;
		private System.Windows.Forms.ToolStripMenuItem mnuOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem mnuSave;
		private System.Windows.Forms.OpenFileDialog dlgOpen;
		private System.Windows.Forms.SaveFileDialog dlgSave;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbAlignLeft;
		private System.Windows.Forms.ToolStripButton tsbAlignCenter;
		private System.Windows.Forms.ToolStripButton tsbAlignRight;
	}
}

