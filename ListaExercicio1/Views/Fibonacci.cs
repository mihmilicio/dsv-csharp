using System;

namespace ListaExercicio1.Views
{
    public static class Fibonacci
    {
        /*
         * Criar um algoritmo que receba um valor positivo inteiro e imprima a sequência Fibonacci até o valor lido.
         * Por exemplo: caso o usuário insira o número 15, o programa deve imprimir na tela os números 0, 1, 1, 2, 3, 5, 8, 13. 
         */

        public static void Exec()
        {
            int limit, num1 = 0, num2 = 1, next;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Fibonacci até o limite");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Insira o limite: ");
            try
            {
                limit = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possível processar o valor inserido. Tente novamente");
                return;
            }

            if (HasReachedLimit(num1, limit))
            {
                Console.WriteLine("Sem números a mostrar");
                return; 
            }
            else
            {
                Console.Write(num1);

                if (HasReachedLimit(num2, limit))
                {
                    return;
                }
                Console.Write($", {num2}");
                
            }
            next = CalcNextNumber(num1, num2);
            do
            {
                Console.Write($", {next}");
                num1 = num2;
                num2 = next;
                next = CalcNextNumber(num1, num2);
            } while (!HasReachedLimit(next, limit));
        }

        private static int CalcNextNumber(int num1, int num2)
        {
            return num1 + num2;
        }

        private static bool HasReachedLimit(int num, int limit)
        {
            return num > limit;
        }
    }
}