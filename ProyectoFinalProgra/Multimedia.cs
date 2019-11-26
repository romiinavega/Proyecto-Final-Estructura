using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgra
{
    class Multimedia : Peliculas 
    {
        public Multimedia(string titulo, int año, string genero, string descripcion, string temporadas, string productor, string ranting)

        {
            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Temporadas = temporadas;
            this.Productor = productor;
            this.Descripcion = descripcion;
            this.Ranting = ranting;
         }

        public Multimedia(string titulo, int año, string genero, string sinopsis, string director, string ranting)
        {
            this.Sinopsis = sinopsis;
            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Director = director;
            this.Ranting = ranting;
        }
     }
}
