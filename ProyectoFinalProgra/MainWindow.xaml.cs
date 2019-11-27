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
            multi.Add(new Multimedia("Mama", 2010, "Miedo", "Una mama que asusta", "3", "Un productor cool", "3"));
            multi.Add(new Multimedia("Hamburguesas", 2000, "Amor", "Comida rica", "1", "Un director muy padre", "5"));
            multi.Add(new Multimedia("Casa de papel", 2016, "Drama", "Roban un banco", "3", "No se que productor es", "5"));
            multi.Add(new Multimedia("Game of thrones", 2011, "Drama", "Basada en los libros de George R.R. Martin, muestra la competencia entre familias nobles de siete reinos de Westeros,", "9", "No se que productor es", "5"));
            list.ItemsSource = multi;
            estrella1.Visibility = Visibility.Hidden;
            estrella2.Visibility = Visibility.Hidden;
            estrella3.Visibility = Visibility.Hidden;
            estrella4.Visibility = Visibility.Hidden;
            estrella5.Visibility = Visibility.Hidden; 




        }

        private void nuevoelemento_Click(object sender, RoutedEventArgs e)
        {
            guardar.Visibility = Visibility.Visible;
            lblTipo.Visibility = Visibility.Visible;
            rbpelicula.Visibility = Visibility.Visible;
            rbserie.Visibility = Visibility.Visible;
            gridN.Children.Clear();
            gridN.Children.Add(new Nuevo_elemento());
            cancelar.Visibility = Visibility.Visible;
            botonN1.Visibility = Visibility.Hidden;
            botonN2.Visibility = Visibility.Hidden;
            botonL1.Visibility = Visibility.Hidden;
            botonL2.Visibility = Visibility.Hidden;
            estrella1.Visibility = Visibility.Hidden;
            estrella2.Visibility = Visibility.Hidden;
            estrella3.Visibility = Visibility.Hidden;
            estrella4.Visibility = Visibility.Hidden;
            estrella5.Visibility = Visibility.Hidden;
            cancelar.Visibility = Visibility.Visible;
            eliminar.Visibility = Visibility.Hidden;
            editar.Visibility = Visibility.Hidden;

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
            
            nuevoelemento.Visibility = Visibility.Hidden;
            if (list.SelectedIndex != -1)
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
                cancelar.Visibility = Visibility.Visible;

                if (((visualizar)(gridN.Children[0])).lblrating.Text == "1")
                {
                    estrella1.Visibility = Visibility.Visible;
                    estrella2.Visibility = Visibility.Hidden;
                    estrella3.Visibility = Visibility.Hidden;
                    estrella4.Visibility = Visibility.Hidden;
                    estrella5.Visibility = Visibility.Hidden;
                }
                if (((visualizar)(gridN.Children[0])).lblrating.Text == "2")
                {
                    estrella2.Visibility = Visibility.Visible;
                    estrella1.Visibility = Visibility.Hidden;
                    estrella3.Visibility = Visibility.Hidden;
                    estrella4.Visibility = Visibility.Hidden;
                    estrella5.Visibility = Visibility.Hidden;
                }
                if (((visualizar)(gridN.Children[0])).lblrating.Text == "3")
                {
                    estrella3.Visibility = Visibility.Visible;
                    estrella2.Visibility = Visibility.Hidden;
                    estrella1.Visibility = Visibility.Hidden;
                    estrella4.Visibility = Visibility.Hidden;
                    estrella5.Visibility = Visibility.Hidden;
                }
                if (((visualizar)(gridN.Children[0])).lblrating.Text == "4")
                {
                    estrella4.Visibility = Visibility.Visible;
                    estrella2.Visibility = Visibility.Hidden;
                    estrella3.Visibility = Visibility.Hidden;
                    estrella1.Visibility = Visibility.Hidden;
                    estrella5.Visibility = Visibility.Hidden;
                }
                if (((visualizar)(gridN.Children[0])).lblrating.Text == "5")
                {
                    estrella5.Visibility = Visibility.Visible;
                    estrella2.Visibility = Visibility.Hidden;
                    estrella3.Visibility = Visibility.Hidden;
                    estrella4.Visibility = Visibility.Hidden;
                    estrella1.Visibility = Visibility.Hidden;
                }
            }
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        { //eliminar

            if (list.SelectedIndex != -1)
            {
                multi.RemoveAt(list.SelectedIndex);
            }
            gridN.Children.Clear();
            estrella1.Visibility = Visibility.Hidden;
            estrella2.Visibility = Visibility.Hidden;
            estrella3.Visibility = Visibility.Hidden;
            estrella4.Visibility = Visibility.Hidden;
            estrella5.Visibility = Visibility.Hidden;
            botonN1.Visibility = Visibility.Visible;
            botonN2.Visibility = Visibility.Visible;
            botonL1.Visibility = Visibility.Visible;
            botonL2.Visibility = Visibility.Visible;
            cancelar.Visibility = Visibility.Hidden;
            eliminar.Visibility = Visibility.Hidden;
            editar.Visibility = Visibility.Hidden;
            eliminar.Visibility = Visibility.Hidden;
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
                ((visualizar)(gridN.Children[0])).cbrating.Text = multi[list.SelectedIndex].Ranting;

                ((visualizar)(gridN.Children[0])).lbltitulo.IsEnabled = true;
                ((visualizar)(gridN.Children[0])).lblsinopsis.IsEnabled = true;
                ((visualizar)(gridN.Children[0])).lblsinopsis.IsEnabled = true;
                ((visualizar)(gridN.Children[0])).lblproduccion.IsEnabled = true;
                ((visualizar)(gridN.Children[0])).lblproduccion.IsEnabled = true;
                ((visualizar)(gridN.Children[0])).lblgenero.IsEnabled = true;
                ((visualizar)(gridN.Children[0])).lbltemporadas.IsEnabled = true;
                ((visualizar)(gridN.Children[0])).lblaño.IsEnabled = true;
                ((visualizar)(gridN.Children[0])).cbrating.IsEnabled = true;
                actualizar.Visibility = Visibility.Visible;
                ((visualizar)(gridN.Children[0])).lblrating.Visibility = Visibility.Hidden;
            
        }

        private void actualizar_Click(object sender, RoutedEventArgs e)
        {
            if (((visualizar)(gridN.Children[0])).lbltitulo.Text == string.Empty || ((visualizar)(gridN.Children[0])).lblaño.Text == string.Empty || ((visualizar)(gridN.Children[0])).lblsinopsis.Text == string.Empty || ((visualizar)(gridN.Children[0])).lblsinopsis.Text == string.Empty || ((visualizar)(gridN.Children[0])).lblproduccion.Text == string.Empty || ((visualizar)(gridN.Children[0])).lblgenero.Text == string.Empty || ((visualizar)(gridN.Children[0])).cbrating.Text == string.Empty)
            {
                restriccion.Visibility = Visibility.Visible;
            }
            else
            {

                gridN.Children.Add(new visualizar());
                var maruchan = ((visualizar)(gridN.Children[0]));
                var pan = multi[list.SelectedIndex];
                var año = pan.Año.ToString();
                var sopa = Convert.ToInt32(((visualizar)(gridN.Children[0])).lblaño.Text);

                pan.Año = sopa;

                pan.Titulo = maruchan.lbltitulo.Text;
                pan.Sinopsis = maruchan.lblsinopsis.Text;
                pan.Descripcion = maruchan.lblsinopsis.Text;
                pan.Temporadas = maruchan.lbltemporadas.Text;
                pan.Productor = maruchan.lblproduccion.Text;
                pan.Genero = maruchan.lblgenero.Text;
                pan.Ranting = maruchan.cbrating.Text;

                restriccion.Visibility = Visibility.Hidden;
                list.Items.Refresh();
                gridN.Children.Clear();
                cancelar.Visibility = Visibility.Hidden;
                eliminar.Visibility = Visibility.Hidden;
                editar.Visibility = Visibility.Hidden;
                actualizar.Visibility = Visibility.Hidden;
                nuevoelemento.Visibility = Visibility.Visible;
                estrella1.Visibility = Visibility.Hidden;
                estrella2.Visibility = Visibility.Hidden;
                estrella3.Visibility = Visibility.Hidden;
                estrella4.Visibility = Visibility.Hidden;
                estrella5.Visibility = Visibility.Hidden;
                botonN1.Visibility = Visibility.Visible;
                botonN2.Visibility = Visibility.Visible;
                botonL1.Visibility = Visibility.Visible;
                botonL2.Visibility = Visibility.Visible;
            }

          /*  var usuario = ((visualizar)(gridN.Children[0]));
            var clase = multi[list.SelectedIndex];
            var año = clase.Año.ToString();
            var año2 = Convert.ToInt32(((visualizar)(gridN.Children[0])).lblaño.Text);
            multi[list.SelectedIndex].Año = año2;
            clase.Titulo = usuario.lbltitulo.Text;
            clase.Sinopsis = usuario.lblsinopsis.Text;
            clase.Temporadas = usuario.lbltemporadas.Text;
            clase.Ranting = usuario.cbrating.Text;
            clase.Productor = usuario.lblproduccion.Text;
            clase.Descripcion = usuario.lblsinopsis.Text;

            list.Items.Refresh();
           
            gridN.Children.Clear();
            estrella1.Visibility = Visibility.Hidden;
            estrella2.Visibility = Visibility.Hidden;
            estrella3.Visibility = Visibility.Hidden;
            estrella4.Visibility = Visibility.Hidden;
            estrella5.Visibility = Visibility.Hidden;
            botonN1.Visibility = Visibility.Visible;
            botonN2.Visibility = Visibility.Visible;
            botonL1.Visibility = Visibility.Visible;
            botonL2.Visibility = Visibility.Visible;
           cancelar.Visibility = Visibility.Hidden;
            eliminar.Visibility = Visibility.Hidden;
            editar.Visibility = Visibility.Hidden;
            actualizar.Visibility = Visibility.Hidden;
            nuevoelemento.Visibility = Visibility.Visible;*/
        }

        private void botonL1_Click(object sender, RoutedEventArgs e)
        {
            bool swap;


            do
            {
                swap = false;
                for (int index = 0; index < (multi.Count - 1); index++)
                {
                    if (string.Compare(multi[index].Titulo, multi[index + 1].Titulo) > 0)
                    {
                        var temp = multi[index];
                        multi[index] = multi[index + 1];
                        multi[index + 1] = temp;
                        swap = true;
                    }

                }
            } while (swap == true);
        }

        private void guardar_Click(object sender, RoutedEventArgs e)
        {
            
            var usuario = ((Serie)(gridN.Children[0]));
            var clase = multi[list.SelectedIndex];

            clase.Titulo = usuario.lbltitulo.Text;
            clase.Sinopsis = usuario.lblsinopsis.Text;
            clase.Temporadas = usuario.lbltemporadas.Text;
            clase.Ranting = usuario.lblrating.Text;
            clase.Productor = usuario.lblproductor.Text;
            clase.Descripcion = usuario.lblsinopsis.Text;


            list.Items.Refresh();




        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        { //cancelar
            nuevoelemento.Visibility = Visibility.Visible;
            gridN.Children.Clear();
            estrella1.Visibility = Visibility.Hidden;
            estrella2.Visibility = Visibility.Hidden;
            estrella3.Visibility = Visibility.Hidden;
            estrella4.Visibility = Visibility.Hidden;
            estrella5.Visibility = Visibility.Hidden;
            botonN1.Visibility = Visibility.Visible;
            botonN2.Visibility = Visibility.Visible;
            botonL1.Visibility = Visibility.Visible;
            botonL2.Visibility = Visibility.Visible;
            cancelar.Visibility = Visibility.Hidden;
            eliminar.Visibility = Visibility.Hidden;
            editar.Visibility = Visibility.Hidden;
            guardar.Visibility = Visibility.Hidden;

        }

        private void botonL2_Click(object sender, RoutedEventArgs e)
        {
            bool swap;


            do
            {
                swap = false;
                for (int index = 0; index < (multi.Count - 1); index++)
                {
                    if (string.Compare(multi[index].Titulo, multi[index + 1].Titulo) < 0)
                    {
                        var temp = multi[index];
                        multi[index] = multi[index + 1];
                        multi[index + 1] = temp;
                        swap = true;
                    }

                }
            } while (swap == true);
        }

        private void RdbtnPelicula_Checked(object sender, RoutedEventArgs e)
        {
            
            cancelar.Visibility = Visibility.Visible;
            eliminar.Visibility = Visibility.Hidden;
            editar.Visibility = Visibility.Hidden;
            estrella1.Visibility = Visibility.Hidden;
            estrella2.Visibility = Visibility.Hidden;
            estrella3.Visibility = Visibility.Hidden;
            estrella4.Visibility = Visibility.Hidden;
            estrella5.Visibility = Visibility.Hidden;

            gridN.Children.Clear();
            gridN.Children.Add(new Nuevo_elemento());
            ((Nuevo_elemento)(gridN.Children[0])).cbtemporadas.Visibility = Visibility.Hidden;
            ((Nuevo_elemento)(gridN.Children[0])).lbltemporada1.Visibility = Visibility.Hidden;
           
        }

        private void RdbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            guardar.Visibility = Visibility.Visible;
            cancelar.Visibility = Visibility.Visible;
            eliminar.Visibility = Visibility.Hidden;
            editar.Visibility = Visibility.Hidden;
            estrella1.Visibility = Visibility.Hidden;
            estrella2.Visibility = Visibility.Hidden;
            estrella3.Visibility = Visibility.Hidden;
            estrella4.Visibility = Visibility.Hidden;
            estrella5.Visibility = Visibility.Hidden;
            gridN.Children.Clear();
            gridN.Children.Add(new Nuevo_elemento());
            ((Nuevo_elemento)(gridN.Children[0])).cbtemporadas.Visibility = Visibility.Visible;
            ((Nuevo_elemento)(gridN.Children[0])).lbltemporada1.Visibility = Visibility.Visible;

            eliminar.Visibility = Visibility.Hidden;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (((Nuevo_elemento)(gridN.Children[0])).lbltitulo.Text == string.Empty || ((Nuevo_elemento)(gridN.Children[0])).lblaño.Text == string.Empty || ((Nuevo_elemento)(gridN.Children[0])).lblsinopsis.Text == string.Empty || ((Nuevo_elemento)(gridN.Children[0])).lblproductor.Text == string.Empty || ((Nuevo_elemento)(gridN.Children[0])).lblgenero.Text == string.Empty || ((Nuevo_elemento)(gridN.Children[0])).cbrating.Text == string.Empty)
            {
                restriccion.Visibility = Visibility.Visible;
            }
            else
            {
                var año = ((Nuevo_elemento)(gridN.Children[0])).lblaño.Text;
                int año2 = int.Parse(año);

                multi.Add(new Multimedia(((Nuevo_elemento)(gridN.Children[0])).lbltitulo.Text, año2, ((Nuevo_elemento)(gridN.Children[0])).lblgenero.Text, ((Nuevo_elemento)(gridN.Children[0])).lblgenero.Text, ((Nuevo_elemento)(gridN.Children[0])).lblproductor.Text, ((Nuevo_elemento)(gridN.Children[0])).lblsinopsis.Text, ((Nuevo_elemento)(gridN.Children[0])).cbrating.Text));
                guardar.Visibility = Visibility.Hidden;
                cancelar.Visibility = Visibility.Hidden;
                gridN.Children.Clear();
                botonN1.Visibility = Visibility.Visible;
                botonN2.Visibility = Visibility.Visible;
                botonL1.Visibility = Visibility.Visible;
                botonL2.Visibility = Visibility.Visible;
                rbserie.Visibility = Visibility.Hidden;
                rbpelicula.Visibility = Visibility.Hidden;
                lblTipo.Visibility = Visibility.Hidden;
                list.Items.Refresh();
            }





           

        }
    }
}

