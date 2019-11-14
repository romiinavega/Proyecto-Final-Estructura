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
using System.Collections.ObjectModel;

namespace ProyectoFinalProgra
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Multimedia> multi = new ObservableCollection<Multimedia>();
        public MainWindow()
        {
            InitializeComponent();
            multi.Add(new Multimedia("Hola", 2010, "sinopsis", "miedo", "hola", 3));
            multi.Add(new Multimedia("Si", 2015, "sinopsis", "terror", "adios", 3));
            multi.Add(new Multimedia("Adios", 2020, "sinopsis", "terror", "si", 3));
            list.ItemsSource = multi;
        }

        private void nuevoelemento_Click(object sender, RoutedEventArgs e)
        {
            gridN.Children.Add(new Nuevo_elemento());
            botonN1.Visibility = Visibility.Hidden;
            botonN2.Visibility = Visibility.Hidden;
            botonL1.Visibility = Visibility.Hidden;
            botonL2.Visibility = Visibility.Hidden;
        }

        private void botonN1_Click(object sender, RoutedEventArgs e)
        {
            { 
                int gap, i;
                gap = multi.Count / 2;


                while (gap > 0)
                {

                    for (i = 0; i < multi.Count; i++)
                    {
                        if (gap + i < multi.Count && multi[i].Año > multi[gap + i].Año)
                        {

                            var temp = multi[i];
                            multi[i] = multi[gap + i];
                            multi[gap + i] = temp;
                        }
                    }

                    gap--;
                }

            }
        }

        private void botonN2_Click(object sender, RoutedEventArgs e)
        {
            {
                int gap, i;
                gap = multi.Count / 2;


                while (gap > 0)
                {

                    for (i = 0; i < multi.Count; i++)
                    {
                        if (gap + i < multi.Count && multi[i].Año < multi[gap + i].Año)
                        {

                            var temp = multi[i];
                            multi[i] = multi[gap + i];
                            multi[gap + i] = temp;
                        }
                    }

                    gap--;
                }

            }
        }
    }
}
