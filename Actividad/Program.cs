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
