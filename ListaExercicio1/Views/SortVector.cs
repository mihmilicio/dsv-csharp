using System;

namespace ListaExercicio1.Views
{
    public static class SortVector
    {
        private static readonly Random Random = new Random();
        static readonly int[] NumberList = new int[10];
        private const int MaxValue = 500;
        
        public static void Exec()
        {
            // fill array randomly
            for (int i = 0; i < NumberList.Length; i++)
            {
                NumberList[i] = Random.Next(MaxValue);
            }
            DisplayArray(NumberList);
            
            // TODO order it manually
            
            
            // order it programmatically 
            Array.Sort(NumberList);
            DisplayArray(NumberList);
        }

        private static void DisplayArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item}   ");
            }
            Console.WriteLine("\n----");
        }
    }
}