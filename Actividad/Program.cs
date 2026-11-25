// =====================================================================
// PARTE 1 - YOKENDDY
// Esta es mi parte del código: pongo las librerías, creo la clase Libros
// con sus propiedades, abro la clase Program con el Main y creo el arreglo
// de la biblioteca.
// Sigue Antoni Ramirez.
// =====================================================================

using System;
using System.IO;

class Libros
{
    public string Codigo { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Anio { get; set; }
    public string Editorial { get; set; }
    public int NumeroPaginas { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Libros[] biblioteca = new Libros[5];

// =================================================================
        // PARTE 2 - ANTONI RAMIREZ
        // Esta es mi parte del código: hago la captura de datos, donde se
        // le piden al usuario los datos de cada uno de los 5 libros.
        // Sigue Dalbert Hernandez.
        // =================================================================

        // Captura de datos
        for (int i = 0; i < biblioteca.Length; i++)
        {
            Console.WriteLine("\n===== LIBRO " + (i + 1) + " =====");

            biblioteca[i] = new Libros();

            Console.Write("Código: ");
            biblioteca[i].Codigo = Console.ReadLine();

            Console.Write("Título: ");
            biblioteca[i].Titulo = Console.ReadLine();

            Console.Write("Autor: ");
            biblioteca[i].Autor = Console.ReadLine();

            Console.Write("Año de publicación: ");
            biblioteca[i].Anio = int.Parse(Console.ReadLine());

            Console.Write("Editorial: ");
            biblioteca[i].Editorial = Console.ReadLine();

            Console.Write("Número de páginas: ");
            biblioteca[i].NumeroPaginas = int.Parse(Console.ReadLine());
        }
