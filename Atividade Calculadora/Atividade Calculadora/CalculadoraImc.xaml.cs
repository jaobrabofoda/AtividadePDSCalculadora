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
using System.Windows.Shapes;

namespace Atividade_Calculadora
{
    /// <summary>
    /// Lógica interna para CalculadoraImc.xaml
    /// </summary>
    public partial class CalculadoraImc : Window
    {
        public CalculadoraImc()
        {
            InitializeComponent();

        }

        private void tbAltura(object sender, TextChangedEventArgs e)
        {
          
        }
        private void tbPeso_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
  

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double imc = peso / (altura * altura);
            lblResultado.Content = "Seu IMC é " + imc.ToString("F2");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            
        }
    }
}
