using System;
using System.Windows.Forms;

namespace Example1Project
{
    public partial class SquareCalcForm : Form
    {
        public SquareCalcForm()
        {
            InitializeComponent();
        }
		private bool IsNum(string numStr)
		{
			try
			{
				int.Parse(numStr);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		private void SquareCalcForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel= true;
            this.Hide();
        }

        private void btnFindSquare_Click(object sender, EventArgs e)
        {
			if (!IsNum(txtNumber.Text))
			{
				MessageBox.Show("Please enter only number!");
				txtNumber.Focus();
				txtNumber.SelectAll();
				return;
			}
			int number = int.Parse(txtNumber.Text);
			int square = (int)Math.Pow(number, 2);
			txtSquare.Text = square.ToString();
		}
    }
}
