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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public static string affichage;
        public static string affichageChamps;
        private ViewModel.Main _vm;

        public MainWindow()

        {

            InitializeComponent();

            _vm = new ViewModel.Main();

            DataContext = _vm;

        }

        private void button1_Click(object sender, RoutedEventArgs e)

        {

            if (tb_input.Text.Length.Equals(0))

            {

                lab_affichage.Content = "Veuillez remplir le champs!";
                affichage = lab_affichage.ToString();

                var message = _vm.message;

                MessageBox.Show(message, MessageBoxButton.YesNo.ToString());

            }

            else

            {

                _vm._champResult = tb_input.Text;
                lab_affichage.Content = tb_input.Text;
                _vm._champResult = lab_affichage.ToString();

                 var message = _vm.message2;

                MessageBox.Show(message);

            }

        }
    }
}
