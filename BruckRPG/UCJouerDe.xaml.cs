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
    /// Interação lógica para UCJouerDe.xam
    /// </summary>
    public partial class UCJouerDe : UserControl
    {
        public UCJouerDe()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            //For first dice
            int iRnd = new int();
            iRnd = r.Next(1, 8);


            if (iRnd == 6)
                pbDado1.Source = new BitmapImage(new Uri("img/dado6.png", UriKind.Relative));
            else if (iRnd == 2)
                pbDado1.Source = new BitmapImage(new Uri("img/dado2.png", UriKind.Relative));
            else if (iRnd == 3)
                pbDado1.Source = new BitmapImage(new Uri("img/dado3.png", UriKind.Relative));
            else if (iRnd == 4)
                pbDado1.Source = new BitmapImage(new Uri("img/dado4.png", UriKind.Relative));
            else if (iRnd == 5)
                pbDado1.Source = new BitmapImage(new Uri("img/dado5.png", UriKind.Relative));
            else
                pbDado1.Source = new BitmapImage(new Uri("img/dado1.png", UriKind.Relative));

            //For second dice
            iRnd = r.Next(1, 8);


            if (iRnd == 6)
                pbDado2.Source = new BitmapImage(new Uri("img/dado6.png", UriKind.Relative));
            else if (iRnd == 2)
                pbDado2.Source = new BitmapImage(new Uri("img/dado2.png", UriKind.Relative));
            else if (iRnd == 3)
                pbDado2.Source = new BitmapImage(new Uri("img/dado3.png", UriKind.Relative));
            else if (iRnd == 4)
                pbDado2.Source = new BitmapImage(new Uri("img/dado4.png", UriKind.Relative));
            else if (iRnd == 5)
                pbDado2.Source = new BitmapImage(new Uri("img/dado5.png", UriKind.Relative));
            else
                pbDado2.Source = new BitmapImage(new Uri("img/dado1.png", UriKind.Relative));


            //For third dice
            iRnd = r.Next(1, 8);


            if (iRnd == 6)
                pbDado3.Source = new BitmapImage(new Uri("img/dado6.png", UriKind.Relative));
            else if (iRnd == 2)
                pbDado3.Source = new BitmapImage(new Uri("img/dado2.png", UriKind.Relative));
            else if (iRnd == 3)
                pbDado3.Source = new BitmapImage(new Uri("img/dado3.png", UriKind.Relative));
            else if (iRnd == 4)
                pbDado3.Source = new BitmapImage(new Uri("img/dado4.png", UriKind.Relative));
            else if (iRnd == 5)
                pbDado3.Source = new BitmapImage(new Uri("img/dado5.png", UriKind.Relative));
            else
                pbDado3.Source = new BitmapImage(new Uri("img/dado1.png", UriKind.Relative));


        }
    }
}
