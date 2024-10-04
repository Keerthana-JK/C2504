using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example12Project
{
	public partial class CounterApp : Form
	{
		public CounterApp()
		{
			InitializeComponent();
			CounterConfig.lblStatus = lblStatus;

		}
		
		private CounterForm counterForm = new CounterForm();
		private ExtendedCounterForm extendedCounterForm = new ExtendedCounterForm();
		private void mnuSimpleCounter_Click(object sender, EventArgs e)
		{
			CounterConfig.ShowChild(this,counterForm);
		}

		private void mnuExtendedCounter_Click(object sender, EventArgs e)
		{
			CounterConfig.ShowChild(this, extendedCounterForm);
		}

		private void CounterApp_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}
}
