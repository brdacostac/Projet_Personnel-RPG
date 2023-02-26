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
    /// Logique d'interaction pour UCPontos.xaml
    /// </summary>
    public partial class UCPontos : UserControl
    {
        public UCPontos()
        {
            InitializeComponent();
        }

        private void MeuTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result) && e.Text != "-";
        }


        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(MeuTextBox.Text, out int value) && MeuTextBox.Text.StartsWith("-"))
            {
                if(int.TryParse(MinhaLabel1.Content.ToString(), out int currentValue))

                MinhaLabel1.Content = currentValue + value;
            }
            else
            {
                if (int.TryParse(MinhaLabel2.Content.ToString(), out int currentValue))
                    MinhaLabel2.Content = currentValue + value;
            }
            
        }


        private void btnEnviar_Click1(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(MeuTextBox1.Text, out int value) && MeuTextBox1.Text.StartsWith("-"))
            {
                if (int.TryParse(MinhaLabel3.Content.ToString(), out int currentValue))

                    MinhaLabel3.Content = currentValue + value;
            }
            else
            {
                if (int.TryParse(MinhaLabel4.Content.ToString(), out int currentValue))
                    MinhaLabel4.Content = currentValue + value;
            }

        }

        private void btnEnviar_Click3(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(MeuTextBox3.Text, out int value) && MeuTextBox3.Text.StartsWith("-"))
            {
                if (int.TryParse(MinhaLabel5.Content.ToString(), out int currentValue))

                    MinhaLabel5.Content = currentValue + value;
            }
            else
            {
                if (int.TryParse(MinhaLabel6.Content.ToString(), out int currentValue))
                    MinhaLabel6.Content = currentValue + value;
            }

        }

        private void btnEnviar_Click4(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(MeuTextBox4.Text, out int value) && MeuTextBox4.Text.StartsWith("-"))
            {
                if (int.TryParse(MinhaLabel7.Content.ToString(), out int currentValue))

                    MinhaLabel7.Content = currentValue + value;
            }
            else
            {
                if (int.TryParse(MinhaLabel8.Content.ToString(), out int currentValue))
                    MinhaLabel8.Content = currentValue + value;
            }

        }

        private void btnEnviar_Click5(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(MeuTextBox5.Text, out int value) && MeuTextBox5.Text.StartsWith("-"))
            {
                if (int.TryParse(MinhaLabel9.Content.ToString(), out int currentValue))

                    MinhaLabel9.Content = currentValue + value;
            }
            else
            {
                if (int.TryParse(MinhaLabel10.Content.ToString(), out int currentValue))
                    MinhaLabel10.Content = currentValue + value;
            }

        }

        private void btnEnviar_Click6(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(MeuTextBox6.Text, out int value) && MeuTextBox6.Text.StartsWith("-"))
            {
                if (int.TryParse(MinhaLabel11.Content.ToString(), out int currentValue))

                    MinhaLabel11.Content = currentValue + value;
            }
            else
            {
                if (int.TryParse(MinhaLabel12.Content.ToString(), out int currentValue))
                    MinhaLabel12.Content = currentValue + value;
            }

        }


    }
}
