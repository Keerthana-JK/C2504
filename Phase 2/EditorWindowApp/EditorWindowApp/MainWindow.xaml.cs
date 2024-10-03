using System.IO;
using System.Windows;
using System.Windows.Media;

namespace EditorWindowApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnOpen_Click(object sender, RoutedEventArgs e)
		{
			var dlg = new System.Windows.Forms.OpenFileDialog();
			var result = dlg.ShowDialog();
			using (var fs = new FileStream(dlg.FileName, FileMode.Open))
			{
				using (var sr = new StreamReader(fs))
				{
					txtEditor.Text=sr.ReadToEnd();
				}
			}
		}

		private void btnSave_Click(object sender, RoutedEventArgs e)
		{
			var dlg = new System.Windows.Forms.SaveFileDialog();
			var result = dlg.ShowDialog();
			using (var fs = new FileStream(dlg.FileName, FileMode.Create))
			{
				using (var sw = new StreamWriter(fs))
				{
					sw.Write(txtEditor.Text);
				}
			}
		}

		private void btnFont_Click(object sender, RoutedEventArgs e)
		{
			var dlg = new System.Windows.Forms.FontDialog();
			var result=dlg.ShowDialog();
			var font = dlg.Font;
			txtEditor.FontSize = font.Size;
		}

		private void btnColor_Click(object sender, RoutedEventArgs e)
		{
			var dlg= new System.Windows.Forms.ColorDialog();
			var result = dlg.ShowDialog();
			//System.Drawing.Color color = dlgColor.Color;
			var color = dlg.Color;
			var newColor = System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
			var brush = new SolidColorBrush(newColor);
			txtEditor.Background = brush;
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}
}
