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
            multi.Add(new Multimedia("Hola", 2010, "miedo", "sinopsis11", "1", "hola", "3"));
            multi.Add(new Multimedia("Si", 2015, "terror", "sinopsis2", "2", "adios", "3"));
            multi.Add(new Multimedia("Adios", 2020, "terror", "sinopsis3", "3", "si", "1"));
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

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridN.Children.Clear();
            gridN.Children.Add(new visualizar());
            // (((Agregar)(gridprincipal.Children)).txtaño.Text);
            //var hola= gridprincipal.Children.Add(new Agregar().txtaño.Text);

            eliminar.Visibility = Visibility.Visible;
            editar.Visibility = Visibility.Visible;
            ((visualizar)(gridN.Children[0])).lbltitulo.Text = multi[list.SelectedIndex].Titulo;
            ((visualizar)(gridN.Children[0])).lblsinopsis.Text = multi[list.SelectedIndex].Sinopsis;
            ((visualizar)(gridN.Children[0])).lblsinopsis.Text = multi[list.SelectedIndex].Descripcion;
            ((visualizar)(gridN.Children[0])).lblproduccion.Text = multi[list.SelectedIndex].Director;
            ((visualizar)(gridN.Children[0])).lblproduccion.Text = multi[list.SelectedIndex].Productor;
            ((visualizar)(gridN.Children[0])).lblgenero.Text = multi[list.SelectedIndex].Genero;
            ((visualizar)(gridN.Children[0])).lbltemporadas.Text = multi[list.SelectedIndex].Temporadas;
            ((visualizar)(gridN.Children[0])).lblrating.Text = multi[list.SelectedIndex].Ranting;
            ((visualizar)(gridN.Children[0])).lblaño.Text = multi[list.SelectedIndex].Año.ToString();
            botonN1.Visibility = Visibility.Hidden;
            botonN2.Visibility = Visibility.Hidden;
            botonL1.Visibility = Visibility.Hidden;
            botonL2.Visibility = Visibility.Hidden;


        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        { //eliminar
            if (list.SelectedIndex != -1)
            {
                multi.RemoveAt(list.SelectedIndex);
            }
        }



        private void editar_Click(object sender, RoutedEventArgs e)
        {
            gridN.Children.Clear();
            gridN.Children.Add(new visualizar());
            ((visualizar)(gridN.Children[0])).lbltitulo.Text = multi[list.SelectedIndex].Titulo;
            ((visualizar)(gridN.Children[0])).lblsinopsis.Text = multi[list.SelectedIndex].Sinopsis;
            ((visualizar)(gridN.Children[0])).lblsinopsis.Text = multi[list.SelectedIndex].Descripcion;
            ((visualizar)(gridN.Children[0])).lblproduccion.Text = multi[list.SelectedIndex].Director;
            ((visualizar)(gridN.Children[0])).lblproduccion.Text = multi[list.SelectedIndex].Productor;
            ((visualizar)(gridN.Children[0])).lblgenero.Text = multi[list.SelectedIndex].Genero;
            ((visualizar)(gridN.Children[0])).lbltemporadas.Text = multi[list.SelectedIndex].Temporadas;
            ((visualizar)(gridN.Children[0])).lblrating.Text = multi[list.SelectedIndex].Ranting;
            ((visualizar)(gridN.Children[0])).lblaño.Text = multi[list.SelectedIndex].Año.ToString();

            ((visualizar)(gridN.Children[0])).lbltitulo.IsEnabled = true;
            ((visualizar)(gridN.Children[0])).lblsinopsis.IsEnabled = true;
            ((visualizar)(gridN.Children[0])).lblsinopsis.IsEnabled = true;
            ((visualizar)(gridN.Children[0])).lblproduccion.IsEnabled = true;
            ((visualizar)(gridN.Children[0])).lblproduccion.IsEnabled = true;
            ((visualizar)(gridN.Children[0])).lblgenero.IsEnabled = true;
            ((visualizar)(gridN.Children[0])).lbltemporadas.IsEnabled = true;
            ((visualizar)(gridN.Children[0])).lblrating.IsEnabled = true;
            ((visualizar)(gridN.Children[0])).lblaño.IsEnabled = true;
            actualizar.Visibility = Visibility.Visible;
            
        }

        private void actualizar_Click(object sender, RoutedEventArgs e)
        {
          
            var usuario = ((visualizar)(gridN.Children[0]));
            var clase = multi[list.SelectedIndex];

            clase.Titulo = usuario.lbltitulo.Text;
            clase.Sinopsis = usuario.lblsinopsis.Text;
            clase.Temporadas = usuario.lbltemporadas.Text;
            clase.Ranting = usuario.lblrating.Text;
            clase.Productor = usuario.lblproduccion.Text;
            clase.Descripcion = usuario.lblsinopsis.Text;

            list.Items.Refresh();


           }

        private void botonL1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

