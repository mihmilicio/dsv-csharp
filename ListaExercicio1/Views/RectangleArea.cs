using System;

namespace ListaExercicio1.Views
{
    public static class RectangleArea
    {
        public static void Exec()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Calculadora de Área de Retângulo");
            Console.WriteLine("--------------------------------");
            Console.Write("Insira a altura: ");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira a largura: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Área: {Calc(height, width)}");
        }

        private static int Calc(int height, int width)
        {
            return height * width;
        }
    }
}