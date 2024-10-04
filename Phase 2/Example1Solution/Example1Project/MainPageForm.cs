using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1Project
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
        }
        //Instantiation - create instance of form
        private SumCalcForm frmSumCalc = new SumCalcForm();
        private SquareCalcForm frmSquareCalc = new SquareCalcForm();
        private SalaryPage frmSalary = new SalaryPage();

		private void MainPageForm_Load(object sender, EventArgs e)
        {

        }

        private void mnuSumCalc_Click(object sender, EventArgs e)
        {
            //forms from back comes to front (to focus on the current form)
            //set parent of the form since we are working with Multiple Document Interface (MDI) appns
            frmSumCalc.MdiParent = this;
			//display form
			frmSumCalc.Show();
			//brings the form referenced by frmSumCalc to front & give it focus
			frmSumCalc.Activate();
        }

        private void mnuSquareCalc_Click(object sender, EventArgs e)
        {
			//forms from back comes to front (to focus on the current form)
			frmSquareCalc.MdiParent = this;
            frmSquareCalc.Show();
			frmSquareCalc.Activate();
		}

        private void mnuSalary_Click(object sender, EventArgs e)
        {
			//forms from back comes to front (to focus on the current form)
			frmSalary.MdiParent = this;
			frmSalary.Show();
			frmSalary.Activate();
		}

        private void mnuContact_Click(object sender, EventArgs e)
        {

        }

        private void mnuContactList_Click(object sender, EventArgs e)
        {

        }

        private void mnuNewContact_Click(object sender, EventArgs e)
        {

        }

		private void MainPageForm_FormClosing(object sender, FormClosingEventArgs e)
		{
            e.Cancel = true;
            this.Hide();
		}
	}
}
