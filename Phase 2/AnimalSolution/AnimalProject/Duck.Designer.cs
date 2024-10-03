namespace AnimalProject
{
	partial class frmDuck
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDuck));
			this.picBoxDuck = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picBoxDuck)).BeginInit();
			this.SuspendLayout();
			// 
			// picBoxDuck
			// 
			this.picBoxDuck.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDuck.Image")));
			this.picBoxDuck.Location = new System.Drawing.Point(26, 12);
			this.picBoxDuck.Name = "picBoxDuck";
			this.picBoxDuck.Size = new System.Drawing.Size(762, 407);
			this.picBoxDuck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBoxDuck.TabIndex = 0;
			this.picBoxDuck.TabStop = false;
			// 
			// frmDuck
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.picBoxDuck);
			this.Name = "frmDuck";
			this.Text = "Duck";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmDuck_Load);
			((System.ComponentModel.ISupportInitialize)(this.picBoxDuck)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picBoxDuck;
	}
}