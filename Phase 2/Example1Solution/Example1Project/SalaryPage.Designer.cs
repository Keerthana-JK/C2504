namespace Example1Project
{
    partial class SalaryPage
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnLoad = new System.Windows.Forms.Button();
			this.lblTitleNewSalary = new System.Windows.Forms.Label();
			this.lblTitleEditSalary = new System.Windows.Forms.Label();
			this.lblJobTitle = new System.Windows.Forms.Label();
			this.lblSalary = new System.Windows.Forms.Label();
			this.txtJobTitle = new System.Windows.Forms.TextBox();
			this.txtSalary = new System.Windows.Forms.TextBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtEditSalary = new System.Windows.Forms.TextBox();
			this.txtEditJobTitle = new System.Windows.Forms.TextBox();
			this.lblEditSalary = new System.Windows.Forms.Label();
			this.lblEditJobTitle = new System.Windows.Forms.Label();
			this.grdSalaries = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.cmbSalaries = new System.Windows.Forms.ComboBox();
			this.lstSalaries = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.grdSalaries)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTitle.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(1300, 107);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "Salary";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(24, 70);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(135, 37);
			this.btnLoad.TabIndex = 3;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// lblTitleNewSalary
			// 
			this.lblTitleNewSalary.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.lblTitleNewSalary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleNewSalary.Location = new System.Drawing.Point(25, 120);
			this.lblTitleNewSalary.Name = "lblTitleNewSalary";
			this.lblTitleNewSalary.Size = new System.Drawing.Size(365, 30);
			this.lblTitleNewSalary.TabIndex = 4;
			this.lblTitleNewSalary.Text = "New Salary";
			this.lblTitleNewSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTitleEditSalary
			// 
			this.lblTitleEditSalary.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.lblTitleEditSalary.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleEditSalary.Location = new System.Drawing.Point(490, 120);
			this.lblTitleEditSalary.Name = "lblTitleEditSalary";
			this.lblTitleEditSalary.Size = new System.Drawing.Size(371, 30);
			this.lblTitleEditSalary.TabIndex = 5;
			this.lblTitleEditSalary.Text = "Edit Salary";
			this.lblTitleEditSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblJobTitle
			// 
			this.lblJobTitle.AutoSize = true;
			this.lblJobTitle.Location = new System.Drawing.Point(34, 237);
			this.lblJobTitle.Name = "lblJobTitle";
			this.lblJobTitle.Size = new System.Drawing.Size(96, 25);
			this.lblJobTitle.TabIndex = 6;
			this.lblJobTitle.Text = "Job Title";
			// 
			// lblSalary
			// 
			this.lblSalary.AutoSize = true;
			this.lblSalary.Location = new System.Drawing.Point(34, 286);
			this.lblSalary.Name = "lblSalary";
			this.lblSalary.Size = new System.Drawing.Size(77, 25);
			this.lblSalary.TabIndex = 7;
			this.lblSalary.Text = "Salary";
			// 
			// txtJobTitle
			// 
			this.txtJobTitle.Location = new System.Drawing.Point(154, 239);
			this.txtJobTitle.Name = "txtJobTitle";
			this.txtJobTitle.Size = new System.Drawing.Size(236, 32);
			this.txtJobTitle.TabIndex = 8;
			// 
			// txtSalary
			// 
			this.txtSalary.Location = new System.Drawing.Point(154, 282);
			this.txtSalary.Name = "txtSalary";
			this.txtSalary.Size = new System.Drawing.Size(236, 32);
			this.txtSalary.TabIndex = 9;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(117, 162);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(135, 37);
			this.btnClear.TabIndex = 10;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(36, 350);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(94, 40);
			this.btnAdd.TabIndex = 11;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(495, 353);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(94, 40);
			this.btnSave.TabIndex = 17;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtEditSalary
			// 
			this.txtEditSalary.Location = new System.Drawing.Point(613, 285);
			this.txtEditSalary.Name = "txtEditSalary";
			this.txtEditSalary.Size = new System.Drawing.Size(236, 32);
			this.txtEditSalary.TabIndex = 15;
			// 
			// txtEditJobTitle
			// 
			this.txtEditJobTitle.Location = new System.Drawing.Point(613, 242);
			this.txtEditJobTitle.Name = "txtEditJobTitle";
			this.txtEditJobTitle.Size = new System.Drawing.Size(236, 32);
			this.txtEditJobTitle.TabIndex = 14;
			// 
			// lblEditSalary
			// 
			this.lblEditSalary.AutoSize = true;
			this.lblEditSalary.Location = new System.Drawing.Point(493, 289);
			this.lblEditSalary.Name = "lblEditSalary";
			this.lblEditSalary.Size = new System.Drawing.Size(77, 25);
			this.lblEditSalary.TabIndex = 13;
			this.lblEditSalary.Text = "Salary";
			// 
			// lblEditJobTitle
			// 
			this.lblEditJobTitle.AutoSize = true;
			this.lblEditJobTitle.Location = new System.Drawing.Point(493, 240);
			this.lblEditJobTitle.Name = "lblEditJobTitle";
			this.lblEditJobTitle.Size = new System.Drawing.Size(96, 25);
			this.lblEditJobTitle.TabIndex = 12;
			this.lblEditJobTitle.Text = "Job Title";
			// 
			// grdSalaries
			// 
			this.grdSalaries.AllowUserToAddRows = false;
			this.grdSalaries.AllowUserToDeleteRows = false;
			this.grdSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdSalaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
			this.grdSalaries.Location = new System.Drawing.Point(42, 410);
			this.grdSalaries.Name = "grdSalaries";
			this.grdSalaries.ReadOnly = true;
			this.grdSalaries.RowHeadersWidth = 51;
			this.grdSalaries.RowTemplate.Height = 24;
			this.grdSalaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdSalaries.Size = new System.Drawing.Size(401, 147);
			this.grdSalaries.TabIndex = 18;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Title";
			this.Column1.HeaderText = "Title";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Salary";
			this.Column2.HeaderText = "Salary";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Display";
			this.Column3.HeaderText = "Display";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Visible = false;
			this.Column3.Width = 125;
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(46, 577);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(133, 40);
			this.btnEdit.TabIndex = 19;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(257, 577);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(133, 40);
			this.btnDelete.TabIndex = 20;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// cmbSalaries
			// 
			this.cmbSalaries.FormattingEnabled = true;
			this.cmbSalaries.Location = new System.Drawing.Point(883, 120);
			this.cmbSalaries.Name = "cmbSalaries";
			this.cmbSalaries.Size = new System.Drawing.Size(155, 33);
			this.cmbSalaries.TabIndex = 21;
			// 
			// lstSalaries
			// 
			this.lstSalaries.FormattingEnabled = true;
			this.lstSalaries.ItemHeight = 25;
			this.lstSalaries.Location = new System.Drawing.Point(888, 202);
			this.lstSalaries.Name = "lstSalaries";
			this.lstSalaries.Size = new System.Drawing.Size(201, 104);
			this.lstSalaries.TabIndex = 22;
			// 
			// SalaryPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1300, 703);
			this.Controls.Add(this.lstSalaries);
			this.Controls.Add(this.cmbSalaries);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.grdSalaries);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtEditSalary);
			this.Controls.Add(this.txtEditJobTitle);
			this.Controls.Add(this.lblEditSalary);
			this.Controls.Add(this.lblEditJobTitle);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.txtSalary);
			this.Controls.Add(this.txtJobTitle);
			this.Controls.Add(this.lblSalary);
			this.Controls.Add(this.lblJobTitle);
			this.Controls.Add(this.lblTitleEditSalary);
			this.Controls.Add(this.lblTitleNewSalary);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "SalaryPage";
			this.Text = "Salary Page";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.grdSalaries)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Label lblTitleNewSalary;
		private System.Windows.Forms.Label lblTitleEditSalary;
		private System.Windows.Forms.Label lblJobTitle;
		private System.Windows.Forms.Label lblSalary;
		private System.Windows.Forms.TextBox txtJobTitle;
		private System.Windows.Forms.TextBox txtSalary;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtEditSalary;
		private System.Windows.Forms.TextBox txtEditJobTitle;
		private System.Windows.Forms.Label lblEditSalary;
		private System.Windows.Forms.Label lblEditJobTitle;
		private System.Windows.Forms.DataGridView grdSalaries;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ComboBox cmbSalaries;
		private System.Windows.Forms.ListBox lstSalaries;
	}
}