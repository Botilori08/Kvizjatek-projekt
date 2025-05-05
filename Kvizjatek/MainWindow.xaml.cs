using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Kvizjatek
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

		List<Kerdeskezel> kerdesek = new List<Kerdeskezel>();
        List<string> valaszok = new List<string>();
        private void Button_Click(object sender, RoutedEventArgs e)
		{
			string kerdes = "";


			for (int i = 0; i < kerdesek.Count; i++)
			{
				kerdes = kerdesek[i].Split(";")[0];

			}

			Kerdes.Text = kerdes;
		}


		private void kviz_Loaded(object sender, RoutedEventArgs e)
        {
            string[] betolt = File.ReadAllLines("kerdes.txt", Encoding.UTF8);
            for (int i = 1; i < betolt.Length; i++)
            {
                kerdesek.Add(new Kerdeskezel();

            }
				
			for (int i = 0; i < kerdesek.Count(); i++)
			{
				valaszok.Add(kerdesek[i].Split(";")[1]);
			}

            Random rand = new Random();

			valasz1.Content = kerdesek[0];
			valasz2.Content = kerdesek[1];

        }
    }
}