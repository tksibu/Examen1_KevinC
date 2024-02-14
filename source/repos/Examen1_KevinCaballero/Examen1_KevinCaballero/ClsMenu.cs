using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_KevinCaballero
{
    internal class ClsMenu
    {
        public static void MostrarMenu()
        {
            ClsBiblioteca biblioteca = new ClsBiblioteca();

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\nBiblioteca UPI");
                Console.WriteLine("\nMenú de opciones:");
                Console.WriteLine("1. Agregar un libro");
                Console.WriteLine("2. Eliminar un libro");
                Console.WriteLine("3. Mostrar todos los libros");
                Console.WriteLine("4. Buscar libros por nombre del autor.");
                Console.WriteLine("5. Mostrar libro mas caro");
                Console.WriteLine("6. Mostrar top tres libros baratos.");
                Console.WriteLine("7. Salir ");

                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite datos del libro: ");
                        Console.Write("Digite el código del libro: ");
                        int cod = int.Parse(Console.ReadLine());
                        Console.Write("Digite el título del libro: ");
                        string title = Console.ReadLine();
                        Console.Write("Digite el autor del libro: ");
                        string autor = Console.ReadLine();
                        Console.Write("Digite fecha del libro: ");
                        String fecha = Console.ReadLine();
                        Console.Write("Digite el precio del libro: ");
                        double precio = double.Parse(Console.ReadLine());

                        ClsLibro nuevoLibro = new ClsLibro(cod, title, autor, fecha, precio);
                        biblioteca.AddLibro(nuevoLibro);
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Digite el código del libro que desea eliminar: ");
                        int eliminar = int.Parse(Console.ReadLine());
                        biblioteca.Delete(eliminar);
                        break;
                    case 3:
                        Console.Clear();
                        biblioteca.imprimirReporte();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Digite nombre del autor: ");
                        
                        break;
                    case 5:
                        Console.Clear();
                        ClsLibro topExpensive = biblioteca.TopExpensive();
                        if (topExpensive != null)
                        {
                            Console.WriteLine("Libro de mayor precio:");
                            topExpensive.ConsultaLibro();
                        }
                        else
                        {
                            Console.WriteLine("No hay libros en la biblioteca.");
                        }
                        break;
                    case 6:
                        Console.Clear();
                        List<ClsLibro> topCheap = biblioteca.TopCheap();
                        if (topCheap.Any())
                        {
                            Console.WriteLine("Top Tres libros más baratos:");
                            foreach (var libro in topCheap)
                            {
                                libro.ConsultaLibro();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay libros en la biblioteca.");
                        }
                        break;
                    case 7:
                        salir = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }   }
}
