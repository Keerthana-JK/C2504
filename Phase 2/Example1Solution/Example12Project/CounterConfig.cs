using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example12Project
{
	static class CounterConfig
	{
		public static int Count { get; set; } = 0;
		public static ToolStripStatusLabel lblStatus { get; set; } = null;
		public static void ShowChild(Form parent, Form child)
		{
			child.MdiParent = parent;
			child.Show();
			child.Activate();
		}

	}
}
