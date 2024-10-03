namespace AnimalProject
{
	partial class frmPeacock
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeacock));
			this.picBoxPeacock = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picBoxPeacock)).BeginInit();
			this.SuspendLayout();
			// 
			// picBoxPeacock
			// 
			this.picBoxPeacock.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPeacock.Image")));
			this.picBoxPeacock.Location = new System.Drawing.Point(115, 58);
			this.picBoxPeacock.Name = "picBoxPeacock";
			this.picBoxPeacock.Size = new System.Drawing.Size(590, 351);
			this.picBoxPeacock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBoxPeacock.TabIndex = 0;
			this.picBoxPeacock.TabStop = false;
			// 
			// frmPeacock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.picBoxPeacock);
			this.Name = "frmPeacock";
			this.Text = "Peacock";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.picBoxPeacock)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picBoxPeacock;
	}
}