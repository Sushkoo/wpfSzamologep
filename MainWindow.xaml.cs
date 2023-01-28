using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

		private void Tetszoleges(object sender, RoutedEventArgs e)
		{
			String eredmeny=$"{txtAszam.Text}+{txtBszam.Text}={Convert.ToDouble(txtAszam.Text)+Convert.ToDouble(txtBszam.Text)}";
			MessageBox.Show("Az összeadás eredménye:" + eredmeny);
			lbEredmenyek.Items.Add(eredmeny);
			//this.Background= new SolidColorBrush(Colors.Black);
		}

		private void btnKivon_Click(object sender, RoutedEventArgs e)
		{
			//this.Width*=2;
		}

		private void btnSzoroz_Click(object sender, RoutedEventArgs e)
		{

		}
		private void btnOszt_Click(object sender, RoutedEventArgs e)
		{
			if (Convert.ToDouble(txtBszam.Text) == 0)
			{
				MessageBox.Show("0-val nem osztunk!");
			}
			else { }
		}
	}
}