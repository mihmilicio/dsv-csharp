using System;

namespace ListaExercicio1.Views
{
    public static class GreaterNumber
    {
        /*
         * Receber dois números inteiros e informar qual valor lido é o menor e qual é o maior. 
         */

        public static void Exec()
        {
            int num1, num2;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Maior e menor número");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Insira o primeiro número: ");
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possível processar o valor inserido. Tente novamente");
                return;
            }
            
            Console.WriteLine("Insira o segundo número: ");
            try
            {
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possível processar o valor inserido. Tente novamente");
                return;
            }
            
            Console.WriteLine();
            if (num1 < num2)
            {
                Console.WriteLine($"O segundo número ({num2}) é maior e o primeiro ({num1}) é menor.");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"O primeiro número ({num1}) é maior e o segundo ({num2}) é menor.");
            }
            else
            {
                Console.WriteLine($"Os números são iguais ({num1})!");
            }
        }
    }
}