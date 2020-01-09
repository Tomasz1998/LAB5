using System;

namespace LAB5
{
    class Program
    {
        // Napisz program wspomagający magazyn biblioteki
        // Kazda ksiązka ma tytuł, magazyn ma 3 regały
        // Regał ma 6 półek, półka ma 10 miejsc.
        // Wskaż gdzie szukać ksiązki na podstawie tytułu
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Black;   
            Ksiazka[,,] array1 = new Ksiazka[3, 6, 10];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        array1[i, j, k] = new Ksiazka("Puste Miejsce", " ", i, j, k);
                    }
                }
            }

            array1[1, 1, 1] = new Ksiazka()
            {
                Tytul = "Potop",
                Autor = "Henryk Sienkiewicz",
                Miejsce = 1,
                Polka = 1,
                Regal = 1,
            };
            array1[2, 4, 6] = new Ksiazka()
            {
                Tytul = "Gra o tron",
                Autor = "George R.R. Martin",
                Miejsce = 6,
                Polka = 4,
                Regal = 2,
            };
            array1[1, 5, 2] = new Ksiazka()
            {
                Tytul = "Wiedzmin",
                Autor = "Andrzej Sapkowski",
                Miejsce = 2,
                Polka = 5,
                Regal = 1,
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        Console.WriteLine(array1[i, j, k].Autor);
                        Console.WriteLine(array1[i, j, k].Tytul);
                    }
                } 
            }
            
            Console.WriteLine("Jakiej książki szukasz");
            string Szukana = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if(array1[i,j,k].Autor == Szukana || array1[i,j,k].Tytul == Szukana)
                        {
                            Console.WriteLine("Ksiązka znajduje się na regale " + i + " w półce " + j + " na miejscu " + k);

                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
