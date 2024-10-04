using System.IO;
using System.Windows;
using System.Windows.Media;
//using System.Windows.Forms;
//using Microsoft.Win32;

namespace WpfExample2
{
	/// <summary>
	/// Interaction logic for EditorWindow.xaml
	/// </summary>
	public partial class EditorWindow : Window
	{
		public EditorWindow()
		{
			InitializeComponent();
		}
		private System.Windows.Forms.OpenFileDialog dlgOpen = new System.Windows.Forms.OpenFileDialog();
		private System.Windows.Forms.SaveFileDialog dlgSave = new System.Windows.Forms.SaveFileDialog();
		private System.Windows.Forms.FontDialog dlgFont = new System.Windows.Forms.FontDialog();
		private System.Windows.Forms.ColorDialog dlgColor = new System.Windows.Forms.ColorDialog();

		private void btnLeft_Click(object sender, RoutedEventArgs e)
		{
			txtEditor.HorizontalContentAlignment= HorizontalAlignment.Left;
			lblStatus.Text = "Left Aligned";
		}

		private void btnCenter_Click(object sender, RoutedEventArgs e)
		{
			txtEditor.HorizontalContentAlignment = HorizontalAlignment.Center;
			lblStatus.Text = "Center Aligned";
		}

		private void btnRight_Click(object sender, RoutedEventArgs e)
		{
			txtEditor.HorizontalContentAlignment = HorizontalAlignment.Right;
			lblStatus.Text = "Right Aligned";
		}

		private void mnuRed_Click(object sender, RoutedEventArgs e)
		{
			txtEditor.Background = Brushes.OrangeRed;
		}

		private void mnuBlue_Click(object sender, RoutedEventArgs e)
		{
			txtEditor.Background = Brushes.CadetBlue;
		}

		private void mnuGreen_Click(object sender, RoutedEventArgs e)
		{
			txtEditor.Background = Brushes.GreenYellow;
		}
		private void mnuOpen_Click(object sender, RoutedEventArgs e)
		{
			var result = dlgOpen.ShowDialog();
			using (FileStream fs = new FileStream(dlgOpen.FileName, FileMode.Open))
			{
				using (StreamReader sr = new StreamReader(fs))
				{
					txtEditor.Text = sr.ReadToEnd();
				}
			}
		}

		private void mnuSave_Click(object sender, RoutedEventArgs e)
		{
			var result = dlgSave.ShowDialog();
			using (FileStream fs = new FileStream(dlgSave.FileName, FileMode.Create))
			{
				using (StreamWriter sr = new StreamWriter(fs))
				{
					sr.Write(txtEditor.Text);
				}
			}
		}

		private void mnuFile_Click(object sender, RoutedEventArgs e)
		{

		}

		private void mnuBackgroundColor_Click(object sender, RoutedEventArgs e)
		{

		}

		private void mnuFont_Click(object sender, RoutedEventArgs e)
		{
			var result = dlgFont.ShowDialog();
			System.Drawing.Font font = dlgFont.Font;
			txtEditor.FontFamily = new FontFamily(font.Name);
			txtEditor.FontSize = font.Size;
			txtEditor.FontWeight = font.Bold ? FontWeights.Bold : FontWeights.Regular;
			txtEditor.FontStyle = font.Italic ? FontStyles.Italic : FontStyles.Normal;
		}

		private void mnuMoreBackColor_Click(object sender, RoutedEventArgs e)
		{
			var result = dlgColor.ShowDialog();
			System.Drawing.Color color = dlgColor.Color;
			txtEditor.Background = new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B));
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}

}
