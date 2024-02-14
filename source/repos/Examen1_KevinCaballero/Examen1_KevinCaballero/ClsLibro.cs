using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_KevinCaballero
{
    internal class ClsLibro
    {
        public interface ILibro
        {
            void PrestamoLibro();
            void ConsultaLibro();
            void devolucionLibro();
            
        }
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public String FechaPublicacion { get; set; }
        public double Precio { get; set; }
        public bool Available { get; set; }

        public ClsLibro(int codigo, string titulo, string autor, String fechaPublicacion, double precio)
        {
            Codigo = codigo;
            Titulo = titulo;
            Autor = autor;
            FechaPublicacion = fechaPublicacion;
            Precio = precio;
            Available = true;
        }
        public void ConsultaLibro()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Fecha de Publicación: {FechaPublicacion}, Precio: {Precio}, Available: {(Available ? "Sí" : "No")}");
        }
        

        public void devolucionLibro()
        {
          
        }
        public void PrestamoLibro()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine("El libro se ha prestado.");
            }
            else
            {
                Console.WriteLine("Libro no Available");
            }
        }
    }
}
