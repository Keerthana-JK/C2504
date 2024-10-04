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
	public partial class ExtendedCounterForm : Form
	{
		public ExtendedCounterForm()
		{
			InitializeComponent();
			lblExtendedCounter.Text = CounterConfig.Count.ToString();
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			CounterConfig.Count+=(int)txtStep.Value;
			lblExtendedCounter.Text = CounterConfig.Count.ToString();
			
		}

		private void btnMinus_Click(object sender, EventArgs e)
		{
			CounterConfig.Count -= (int)txtStep.Value;
			lblExtendedCounter.Text = CounterConfig.Count.ToString();
		}

		private void ExtendedCounter_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void txtStep_ValueChanged(object sender, EventArgs e)
		{
			//
		}
	}
}
