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
            MessageBox.Show("BIENVENIDO");
        }
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            string nombre = txtDATOS.Text;
            string apellido = txtAPELLIDOS.Text;
           
           
            if (IsNumeric(txtEDAD.Text))
            {
                int edad = int.Parse(txtEDAD.Text);
                MessageBox.Show(" Se ha registrado: " + nombre + " " + apellido + " de " + edad + " años");
            }
            else
            {
                MessageBox.Show(" Ingrese un numero en edad");

            }

            

        }

        private void txtAPELLIDOS_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
