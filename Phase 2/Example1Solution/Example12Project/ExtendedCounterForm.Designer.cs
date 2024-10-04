namespace Example12Project
{
	partial class ExtendedCounterForm
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
			this.lblStep = new System.Windows.Forms.Label();
			this.txtStep = new System.Windows.Forms.NumericUpDown();
			this.btnMinus = new System.Windows.Forms.Button();
			this.btnPlus = new System.Windows.Forms.Button();
			this.lblExtendedCounter = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.txtStep)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStep
			// 
			this.lblStep.AutoSize = true;
			this.lblStep.Location = new System.Drawing.Point(347, 236);
			this.lblStep.Name = "lblStep";
			this.lblStep.Size = new System.Drawing.Size(33, 16);
			this.lblStep.TabIndex = 14;
			this.lblStep.Text = "step";
			// 
			// txtStep
			// 
			this.txtStep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStep.Location = new System.Drawing.Point(357, 264);
			this.txtStep.Name = "txtStep";
			this.txtStep.Size = new System.Drawing.Size(83, 34);
			this.txtStep.TabIndex = 13;
			this.txtStep.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.txtStep.ValueChanged += new System.EventHandler(this.txtStep_ValueChanged);
			// 
			// btnMinus
			// 
			this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinus.Location = new System.Drawing.Point(485, 244);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(104, 66);
			this.btnMinus.TabIndex = 12;
			this.btnMinus.Text = "-";
			this.btnMinus.UseVisualStyleBackColor = true;
			this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
			// 
			// btnPlus
			// 
			this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlus.Location = new System.Drawing.Point(218, 246);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(104, 66);
			this.btnPlus.TabIndex = 11;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// lblExtendedCounter
			// 
			this.lblExtendedCounter.BackColor = System.Drawing.Color.MistyRose;
			this.lblExtendedCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExtendedCounter.Location = new System.Drawing.Point(212, 139);
			this.lblExtendedCounter.Name = "lblExtendedCounter";
			this.lblExtendedCounter.Size = new System.Drawing.Size(377, 63);
			this.lblExtendedCounter.TabIndex = 10;
			this.lblExtendedCounter.Text = "0";
			this.lblExtendedCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ExtendedCounterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblStep);
			this.Controls.Add(this.txtStep);
			this.Controls.Add(this.btnMinus);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.lblExtendedCounter);
			this.Name = "ExtendedCounterForm";
			this.Text = "Extended Counter";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExtendedCounter_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.txtStep)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStep;
		private System.Windows.Forms.NumericUpDown txtStep;
		private System.Windows.Forms.Button btnMinus;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Label lblExtendedCounter;
	}
}