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
        private static readonly int[] InitialList = new int[10];
        private static readonly int[] OrderedList = new int[10];
        private const int MaxValue = 500;

        public static void Exec()
        {
            // fill array randomly
            for (var i = 0; i < InitialList.Length; i++)
            {
                InitialList[i] = Random.Next(MaxValue);
            }

            DisplayArray(InitialList);

            // order it manually
            for (var i = 0; i < OrderedList.Length; i++)
            {
                OrderedList[i] = -1;
            }
            
            foreach (var item in InitialList)
            {
                for (var j = 0; j < OrderedList.Length; j++)
                {
                    if (OrderedList[j] != -1 && OrderedList[j] <= item) continue;
                    AddItemInPosition(item, j);
                    break;
                }
            }

            DisplayArray(OrderedList);

            // order it programmatically 
            Array.Sort(InitialList);
            DisplayArray(InitialList);
        }

        private static void DisplayArray(IEnumerable<int> array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item}   ");
            }

            Console.WriteLine("\n----");
        }

        private static void AddItemInPosition(int item, int pos)
        {
            for (var i = OrderedList.Length - 1; i >= pos && i > 0; i--)
            {
                OrderedList[i] = OrderedList[i - 1];
            }
            OrderedList[pos] = item;
        }
    }
}