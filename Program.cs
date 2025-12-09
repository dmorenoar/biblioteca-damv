using System;

namespace BibliotecaDemo
{
    class Program
    {
        // Variables globals (ERROR:ús excessiu de variables globals)
        static string[] titols = new string[100];
        static string[] autors = new string[100];
        static int[] anys = new int[100];
        static int comptador = 0;

        static void Main(string[] args)
        {
            bool sortir = false;

            Console.WriteLine("=== SISTEMA DE GESTIÓ DE BIBLIOTECA ===");
            Console.WriteLine();

            // Afegir alguns llibres de prova
           /* AfegirLlibre("El Quixot", "Cervantes", 1605);
            AfegirLlibre("1984", "Orwell", 1949);
            AfegirLlibre("", "", 0); // ERROR: dades buides permeses*/

            while (!sortir)
            {
                MostrarMenu();
                string? opcio = Console.ReadLine();

                // ERROR: No es valida l'entrada de l'usuari
                ProcessarOpcio(opcio, ref sortir);
            }

            Console.WriteLine("Adéu!");
        }

        // ERROR: funció massa llarga i complexa
        static void MostrarMenu()
        {
            Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
            Console.WriteLine("1. Mostrar tots els llibres");
            Console.WriteLine("2. Cercar llibre per títol");
            Console.WriteLine("3. Afegir llibre nou");
            Console.WriteLine("4. Estadístiques");
            Console.WriteLine("5. Sortir");
            Console.Write("Tria una opció: ");
        }

        // ERROR: massa complexitat ciclomàtica
        static void ProcessarOpcio(string opcio, ref bool sortir)
        {
            if (opcio == "1")
            {
                //MostrarTotesLlibres();
            }
            else if (opcio == "2")
            {
                Console.Write("Introdueix el títol a cercar: ");
                string titol = Console.ReadLine();
                // int posicio = CercarLlibre(titol);
                int posicio = 0;
                // ERROR: possible IndexOutOfRangeException
                if (posicio >= 0)
                {
                    Console.WriteLine($"\nLlibre trobat:");
                    Console.WriteLine($"Títol: {titols[posicio]}");
                    Console.WriteLine($"Autor: {autors[posicio]}");
                    Console.WriteLine($"Any: {anys[posicio]}");
                }
                else
                {
                    Console.WriteLine("Llibre no trobat.");
                }
            }
            else if (opcio == "3")
            {
                Console.Write("Títol: ");
                string titol = Console.ReadLine();
                Console.Write("Autor: ");
                string autor = Console.ReadLine();
                Console.Write("Any: ");
                // ERROR: no es controla l'excepció si l'usuari no introdueix un número
                int any = int.Parse(Console.ReadLine());

               // AfegirLlibre(titol, autor, any);
            }
            else if (opcio == "4")
            {
               // MostrarEstadistiques();
            }
            else if (opcio == "5")
            {
                sortir = true;
            }
            else
            {
                Console.WriteLine("Opció no vàlida.");
            }
        }
    }
}