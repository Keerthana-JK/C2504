namespace Example12Project
{
	partial class CounterApp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounterApp));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuSimpleCounter = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExtendedCounter = new System.Windows.Forms.ToolStripMenuItem();
			this.stsBar = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.stsBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSimpleCounter,
            this.mnuExtendedCounter});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
			this.menuStrip1.Size = new System.Drawing.Size(1100, 32);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuSimpleCounter
			// 
			this.mnuSimpleCounter.Name = "mnuSimpleCounter";
			this.mnuSimpleCounter.Size = new System.Drawing.Size(125, 24);
			this.mnuSimpleCounter.Text = "&Simple Counter";
			this.mnuSimpleCounter.Click += new System.EventHandler(this.mnuSimpleCounter_Click);
			// 
			// mnuExtendedCounter
			// 
			this.mnuExtendedCounter.Name = "mnuExtendedCounter";
			this.mnuExtendedCounter.Size = new System.Drawing.Size(141, 24);
			this.mnuExtendedCounter.Text = "&Extended Counter";
			this.mnuExtendedCounter.Click += new System.EventHandler(this.mnuExtendedCounter_Click);
			// 
			// stsBar
			// 
			this.stsBar.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.stsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.stsBar.Location = new System.Drawing.Point(0, 762);
			this.stsBar.Name = "stsBar";
			this.stsBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.stsBar.Size = new System.Drawing.Size(1100, 26);
			this.stsBar.TabIndex = 1;
			this.stsBar.Text = "Status Bar";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(83, 20);
			this.lblStatus.Text = "Welcome!!!";
			// 
			// CounterApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1100, 788);
			this.Controls.Add(this.stsBar);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "CounterApp";
			this.Text = "Counter App";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CounterApp_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.stsBar.ResumeLayout(false);
			this.stsBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnuSimpleCounter;
		private System.Windows.Forms.ToolStripMenuItem mnuExtendedCounter;
		private System.Windows.Forms.StatusStrip stsBar;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
	}
}

