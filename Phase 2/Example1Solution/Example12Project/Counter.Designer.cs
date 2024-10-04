namespace Example12Project
{
	partial class CounterForm
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
			this.btnMinus = new System.Windows.Forms.Button();
			this.btnPlus = new System.Windows.Forms.Button();
			this.lblCounter = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnMinus
			// 
			this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinus.Location = new System.Drawing.Point(431, 248);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(104, 66);
			this.btnMinus.TabIndex = 6;
			this.btnMinus.Text = "-";
			this.btnMinus.UseVisualStyleBackColor = true;
			this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
			// 
			// btnPlus
			// 
			this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlus.Location = new System.Drawing.Point(265, 248);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(104, 66);
			this.btnPlus.TabIndex = 5;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// lblCounter
			// 
			this.lblCounter.BackColor = System.Drawing.Color.MistyRose;
			this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCounter.Location = new System.Drawing.Point(265, 137);
			this.lblCounter.Name = "lblCounter";
			this.lblCounter.Size = new System.Drawing.Size(270, 63);
			this.lblCounter.TabIndex = 4;
			this.lblCounter.Text = "0";
			this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CounterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnMinus);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.lblCounter);
			this.Name = "CounterForm";
			this.Text = "Counter";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CounterForm_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnMinus;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Label lblCounter;
	}
}