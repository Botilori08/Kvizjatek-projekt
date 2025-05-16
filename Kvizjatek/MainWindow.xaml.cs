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

		int kerdesId;
        Random rand = new Random();
		List<Kerdeskezel> kerdesek = new List<Kerdeskezel>();


		private void kviz_Loaded(object sender, RoutedEventArgs e)
        {
            string[] betolt = File.ReadAllLines("kerdes.txt", Encoding.UTF8);
            for (int i = 1; i < betolt.Length; i++)
            {
                kerdesek.Add(new Kerdeskezel(betolt[i]));

            }
			kerdesId = rand.Next(kerdesek.Count);


			var keveres = kerdesek[kerdesId].randomValasz();
			Kerdes.Text = kerdesek[kerdesId].kerdes;

			valasz1.Content = keveres[0];
			valasz2.Content = keveres[1];
            valasz3.Content = keveres[2];
            valasz4.Content = keveres[3];




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}