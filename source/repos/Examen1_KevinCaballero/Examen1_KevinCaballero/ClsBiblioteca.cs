using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Examen1_KevinCaballero.ClsLibro;

namespace Examen1_KevinCaballero
{
    internal class ClsBiblioteca
    {
        private List<ClsLibro> libros;

        public ClsBiblioteca()
        {
            libros = new List<ClsLibro>();
        }

        public void AddLibro(ClsLibro libro)
        {   
            libros.Add(libro);
            Console.WriteLine("Libro agregado Exitosamente !!!");
        }

        public void Delete(int codigo)
        {
            ClsLibro libro = libros.FirstOrDefault(l => l.Codigo == codigo);
            if (libro != null)
            {
                libros.Remove(libro);
                Console.WriteLine("Eliminado Exitosamente");
            }
            else
            {
                Console.WriteLine("Codigo Invalido");
            }
        }

        public void imprimirReporte()
        {
            Console.WriteLine("Reporte de Libros");
            foreach (var libro in libros)
            {
                libro.ConsultaLibro();
            }
        }

        public void Busqueda()
        {
             Console.WriteLine("PENDIENTE DESARROLLO");
        }

        public ClsLibro TopExpensive()
        {
            return libros.OrderByDescending(l => l.Precio).FirstOrDefault();
        }

        public List<ClsLibro> TopCheap()
        {
            return libros.OrderBy(l => l.Precio).Take(3).ToList();
        }
    }
}
