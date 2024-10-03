using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalProject
{
	public partial class frmAnimalHomePage : Form
	{
		public frmAnimalHomePage()
		{
			InitializeComponent();
		}
		//Instantiation - create instance of form
		private frmDuck frmDuck = new frmDuck();
		private frmPeacock frmPeacock = new frmPeacock();
		private frmCrow frmCrow = new frmCrow();

		private void mnuDuck_Click(object sender, EventArgs e)
		{
			frmDuck.MdiParent = this;
			frmDuck.Show();
			frmDuck.Activate();
		}

		private void mnuPeacock_Click(object sender, EventArgs e)
		{
			frmPeacock.MdiParent = this;
			frmPeacock.Show();
			frmPeacock.Activate();
		}

		private void mnuCrow_Click(object sender, EventArgs e)
		{
			frmCrow.MdiParent = this;
			frmCrow.Show();
			frmCrow.Activate();
		}

		private void MainPageForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}
}
