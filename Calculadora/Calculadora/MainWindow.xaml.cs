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

namespace Calculadora
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
           double Op1 = Double.Parse(txtOperador1.Text);
           double Op2 = Double.Parse(txtOperador2.Text);
           string resultado = txtResultado.Text;


            logicaCalculadora laLogica = new logicaCalculadora();
            txtResultado.Text = laLogica.RealizarOperacion(txtOperador1.Text, txtOperador2.Text, txtResultado.Text);
/*
            double result;     
            switch (cbOperadores.Text)
            {
                case "Suma":
                result = Double.Parse(txtOperador1.Text) + Double.Parse(txtOperador2.Text);
                txtResultado.Text = result.ToString();
                    break;
                case "Resta":
                    result = Double.Parse(txtOperador1.Text) - Double.Parse(txtOperador2.Text);
                    txtResultado.Text = result.ToString();
                    break;
                case "Multiplicación":
                    result = Double.Parse(txtOperador1.Text) * Double.Parse(txtOperador2.Text);
                    txtResultado.Text = result.ToString();
                    break;
                case "División":
                    result = Double.Parse(txtOperador1.Text) / Double.Parse(txtOperador2.Text);
                    txtResultado.Text = result.ToString();
                    break;          
            }
*/
        }
    }
}