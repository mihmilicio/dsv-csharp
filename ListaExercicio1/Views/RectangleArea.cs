using System;

namespace ListaExercicio1.Views
{
    public static class RectangleArea
    {
        /*
         * Escrever um algoritmo que receba a altura e a largura de um retângulo e calcule a sua área.
         */
        public static void Exec()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Calculadora de Área de Retângulo");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Insira a altura: ");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a largura: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Área: {Calc(height, width)}");
        }

        private static int Calc(int height, int width)
        {
            return height * width;
        }
    }
}