namespace Example1Project
{
    partial class MainPageForm
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
			this.mnuBar = new System.Windows.Forms.MenuStrip();
			this.mnuCalculator = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSumCalc = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDividerCalc1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuSquareCalc = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuSalary = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuContact = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuContactList = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNewContact = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuBar
			// 
			this.mnuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCalculator,
            this.mnuSalary,
            this.mnuContact});
			this.mnuBar.Location = new System.Drawing.Point(0, 0);
			this.mnuBar.Name = "mnuBar";
			this.mnuBar.Size = new System.Drawing.Size(1300, 28);
			this.mnuBar.TabIndex = 1;
			this.mnuBar.Text = "menuBar";
			// 
			// mnuCalculator
			// 
			this.mnuCalculator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSumCalc,
            this.mnuDividerCalc1,
            this.mnuSquareCalc,
            this.toolStripSeparator2});
			this.mnuCalculator.Name = "mnuCalculator";
			this.mnuCalculator.Size = new System.Drawing.Size(90, 24);
			this.mnuCalculator.Text = "&Calculator";
			// 
			// mnuSumCalc
			// 
			this.mnuSumCalc.Name = "mnuSumCalc";
			this.mnuSumCalc.Size = new System.Drawing.Size(224, 26);
			this.mnuSumCalc.Text = "&Sum Calculator";
			this.mnuSumCalc.Click += new System.EventHandler(this.mnuSumCalc_Click);
			// 
			// mnuDividerCalc1
			// 
			this.mnuDividerCalc1.Name = "mnuDividerCalc1";
			this.mnuDividerCalc1.Size = new System.Drawing.Size(221, 6);
			// 
			// mnuSquareCalc
			// 
			this.mnuSquareCalc.Name = "mnuSquareCalc";
			this.mnuSquareCalc.Size = new System.Drawing.Size(224, 26);
			this.mnuSquareCalc.Text = "S&quare Calculator";
			this.mnuSquareCalc.Click += new System.EventHandler(this.mnuSquareCalc_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
			// 
			// mnuSalary
			// 
			this.mnuSalary.Name = "mnuSalary";
			this.mnuSalary.Size = new System.Drawing.Size(63, 24);
			this.mnuSalary.Text = "&Salary";
			this.mnuSalary.Click += new System.EventHandler(this.mnuSalary_Click);
			// 
			// mnuContact
			// 
			this.mnuContact.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContactList,
            this.mnuNewContact});
			this.mnuContact.Name = "mnuContact";
			this.mnuContact.Size = new System.Drawing.Size(74, 24);
			this.mnuContact.Text = "C&ontact";
			this.mnuContact.Click += new System.EventHandler(this.mnuContact_Click);
			// 
			// mnuContactList
			// 
			this.mnuContactList.Name = "mnuContactList";
			this.mnuContactList.Size = new System.Drawing.Size(224, 26);
			this.mnuContactList.Text = "C&ontact List";
			this.mnuContactList.Click += new System.EventHandler(this.mnuContactList_Click);
			// 
			// mnuNewContact
			// 
			this.mnuNewContact.Name = "mnuNewContact";
			this.mnuNewContact.Size = new System.Drawing.Size(224, 26);
			this.mnuNewContact.Text = "&New Contact";
			this.mnuNewContact.Click += new System.EventHandler(this.mnuNewContact_Click);
			// 
			// MainPageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1300, 704);
			this.Controls.Add(this.mnuBar);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.mnuBar;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "MainPageForm";
			this.Text = "Example 1 App";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPageForm_FormClosing);
			this.Load += new System.EventHandler(this.MainPageForm_Load);
			this.mnuBar.ResumeLayout(false);
			this.mnuBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuCalculator;
        private System.Windows.Forms.ToolStripMenuItem mnuSumCalc;
        private System.Windows.Forms.ToolStripSeparator mnuDividerCalc1;
        private System.Windows.Forms.ToolStripMenuItem mnuSquareCalc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuSalary;
        private System.Windows.Forms.ToolStripMenuItem mnuContact;
        private System.Windows.Forms.ToolStripMenuItem mnuContactList;
        private System.Windows.Forms.ToolStripMenuItem mnuNewContact;
    }
}

