namespace AnimalProject
{
	partial class frmCrow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrow));
			this.picBoxCrow = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picBoxCrow)).BeginInit();
			this.SuspendLayout();
			// 
			// picBoxCrow
			// 
			this.picBoxCrow.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCrow.Image")));
			this.picBoxCrow.Location = new System.Drawing.Point(78, 56);
			this.picBoxCrow.Name = "picBoxCrow";
			this.picBoxCrow.Size = new System.Drawing.Size(643, 337);
			this.picBoxCrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBoxCrow.TabIndex = 0;
			this.picBoxCrow.TabStop = false;
			// 
			// frmCrow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.picBoxCrow);
			this.Name = "frmCrow";
			this.Text = "Crow";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.picBoxCrow)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picBoxCrow;
	}
}