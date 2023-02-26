using MahApps.Metro.Controls;
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

namespace BruckRPG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Acceuil(object sender, RoutedEventArgs e)
        {
            pagePrincipale.Content = new UCPagePrincipale();
        }
        private void Button_Click_Dados(object sender, RoutedEventArgs e)
        {
            pagePrincipale.Content = new UCJouerDe();
        }

        private void Button_Click_ThreeSerato(object sender, RoutedEventArgs e)
        {
            pagePrincipale.Content = new UCThreeSerato();
        }

        private void Button_Click_Pontos(object sender, RoutedEventArgs e)
        {
            pagePrincipale.Content = new UCPontos();
        }
    }
}
