using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactProject
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnRed_Click(object sender, EventArgs e)
		{
			txtEditor.BackColor=Color.IndianRed;
			stsColor.Text= txtEditor.BackColor.ToString();
		}

		private void btnBlue_Click(object sender, EventArgs e)
		{
			txtEditor.BackColor = Color.Blue;
			stsColor.Text = txtEditor.BackColor.ToString();
		}

		private void btnGreen_Click(object sender, EventArgs e)
		{
			txtEditor.BackColor = Color.Green;
			stsColor.Text = txtEditor.BackColor.ToString();
		}

		private void btnMoreColors_Click(object sender, EventArgs e)
		{
			dlgColor.Color = txtEditor.BackColor;
			var result = dlgColor.ShowDialog();
			if (result == DialogResult.OK)
			{
				txtEditor.BackColor = dlgColor.Color;
				stsColor.Text = txtEditor.BackColor.ToString();
			}
		}

		private void btnPickColor_Click(object sender, EventArgs e)
		{
			
			var result = dlgColor.ShowDialog();
			if (result == DialogResult.OK)
			{
				txtEditor.ForeColor = dlgColor.Color;
				stsColor.Text = txtEditor.ForeColor.ToString();
			}
		}
		/////
		private void mnuRedBG_Click(object sender, EventArgs e)
		{
			btnRed_Click(null, null);
		}

		private void mnuBlueBG_Click(object sender, EventArgs e)
		{
			btnBlue_Click(null, null);
		}

		private void mnuGreenBG_Click(object sender, EventArgs e)
		{
			btnGreen_Click(null, null);
		}

		private void mnuBG_Click(object sender, EventArgs e)
		{
			btnMoreColors_Click(null, null);
		}

		private void mnuFG_Click(object sender, EventArgs e)
		{
			btnPickColor_Click(null, null);
		}

		private void mnuRed2_Click(object sender, EventArgs e)
		{
			btnRed_Click(null, null);
		}

		private void mnuBlue2_Click(object sender, EventArgs e)
		{
			btnBlue_Click(null, null);
		}

		private void mnuGreen2_Click(object sender, EventArgs e)
		{
			btnGreen_Click(null, null);
		}

		private void mnuAlignLeft_Click(object sender, EventArgs e)
		{
			txtEditor.TextAlign=HorizontalAlignment.Left;
		}

		private void mnuAlignCenter_Click(object sender, EventArgs e)
		{
			txtEditor.TextAlign = HorizontalAlignment.Center;
		}

		private void mnuAlignRight_Click(object sender, EventArgs e)
		{
			txtEditor.TextAlign = HorizontalAlignment.Right;
		}

		private void mnuFont_Click(object sender, EventArgs e)
		{
			dlgFont.Font=txtEditor.Font;
			var result = dlgFont.ShowDialog();
			if (result == DialogResult.OK)
			{
				txtEditor.Font=dlgFont.Font;
			}
		}

		private void mnuOpen_Click(object sender, EventArgs e)
		{
			var result = dlgOpen.ShowDialog();
			if (result == DialogResult.OK)
			{
				var filename = dlgOpen.FileName;
				//logic to save
				FileStream fs = null;
				StreamReader sr = null;
				try
				{
					fs = new FileStream(filename, FileMode.Open);
					sr = new StreamReader(fs);
					txtEditor.Text = sr.ReadToEnd();
					//sw.Close();
				}
				catch (FileNotFoundException ex)
				{
					MessageBox.Show($"{ex.Message}");
				}
				catch (IOException ex)
				{
					MessageBox.Show($"{ex.Message}");
				}
				catch (Exception ex)
				{
					MessageBox.Show($"{ex.Message}");
				}
				finally
				{
					if (sr != null)
					{
						sr.Close();
					}
					if (fs != null)
					{
						fs.Close();
					}
				}
			}
		}

		private void mnuSave_Click(object sender, EventArgs e)
		{
			var result = dlgSave.ShowDialog();
			if (result == DialogResult.OK)
			{
				var filename=dlgSave.FileName;
				//logic to save
				FileStream fs = null;
				StreamWriter sw = null;
				try
				{
					fs=new FileStream(filename, FileMode.Create);
					sw = new StreamWriter(fs);
					sw.Write(txtEditor.Text);
					//sw.Close();
				}
				catch (FileNotFoundException ex)
				{
					MessageBox.Show($"{ex.Message}");
				}
				catch (IOException ex) 
				{
					MessageBox.Show($"{ex.Message}");
				}
				catch (Exception ex)
				{
					MessageBox.Show($"{ex.Message}");
				}
				finally 
				{
					if (sw != null)
					{
						sw.Close();
					}
					if (fs != null)
					{
						fs.Close();
					}
				}
			}
		}

		private void tsbAlignLeft_Click(object sender, EventArgs e)
		{
			mnuAlignLeft_Click(null, null);
		}

		private void tsbAlignCenter_Click(object sender, EventArgs e)
		{
			mnuAlignCenter_Click(null, null);
		}

		private void tsbAlignRight_Click(object sender, EventArgs e)
		{
			mnuAlignRight_Click(null, null);
		}
	}
}
