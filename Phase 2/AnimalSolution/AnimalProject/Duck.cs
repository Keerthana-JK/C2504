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
	public partial class frmDuck : Form
	{
		public frmDuck()
		{
			InitializeComponent();
		}

		private void frmDuck_Load(object sender, EventArgs e)
		{

		}
		private void frmDuck_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}
}
