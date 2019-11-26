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

namespace ProyectoFinalProgra
{
    /// <summary>
    /// Lógica de interacción para visualizar.xaml
    /// </summary>
    public partial class visualizar : UserControl
    {
        public visualizar()
        {
            InitializeComponent();
            lblaño.IsEnabled = false;
            lblgenero.IsEnabled = false;
            lblproduccion.IsEnabled = false;
            lblrating.IsEnabled = false;
            lblsinopsis.IsEnabled = false;
            lbltemporadas.IsEnabled = false;
            lbltitulo.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*  lblaño.IsEnabled = false;
            lblgenero.IsEnabled = false;
            lblproduccion.IsEnabled = false;
            lblrating.IsEnabled = false;
            lblsinopsis.IsEnabled = false;
            lbltemporadas.IsEnabled = false;
            lbltitulo.IsEnabled = true;*/
        }
    }
}
