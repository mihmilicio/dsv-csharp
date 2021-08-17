using System;
using System.Collections.Generic;

namespace ListaExercicio1.Views
{
    public static class SortVector
    {
        /*
         * Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e ordenar do menor para o maior. 
            a)	Desenvolver o algoritmo de ordenação;
            b)	Utilizar uma função em C# para ordenação;
         */
        
        private static readonly Random Random = new();
        private static readonly int[] NumberList = new int[10];
        private const int MaxValue = 500;

        public static void Exec()
        {
            // fill array randomly
            for (var i = 0; i < NumberList.Length; i++)
            {
                NumberList[i] = Random.Next(MaxValue);
            }

            DisplayArray(NumberList);

            // TODO order it manually


            // order it programmatically 
            Array.Sort(NumberList);
            DisplayArray(NumberList);
        }

        private static void DisplayArray(IEnumerable<int> array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item}   ");
            }

            Console.WriteLine("\n----");
        }
    }
}