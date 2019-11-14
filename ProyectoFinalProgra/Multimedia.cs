using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgra
{
    class Multimedia : Peliculas
    {
        public Multimedia(string titulo, int año, string genero, int temporadas, string productor, string descripcion, int ranting)

        {
            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Temporadas = temporadas;
            this.Productor = productor;
            this.Descripcion = descripcion;
            this.Ranting = ranting;
         }

        public Multimedia(string titulo, int año, string sinopsis, string genero, string director, int ranting)
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
