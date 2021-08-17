using System;

namespace ListaExercicio1.Views
{
    public static class AgeGroup
    {
        /*
         * Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa e imprimir uma das mensagens:
         * se idade <= 13: Criança,
         * se idade > 13 e <= 18: Adolescente,
         * se idade > 18 e <= 60: Adulto e
         * se idade > 60: Idoso. 
         */

        public static void Exec()
        {
            int age;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Faixa etária");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Insira a idade:");
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possível processar o valor inserido. Tente novamente");
                return;
            }

            Console.WriteLine();
            switch (age)
            {
                case <= 13:
                    Console.WriteLine("Criança");
                    break;
                case <= 18:
                    Console.WriteLine("Adolescente");
                    break;
                case <= 60:
                    Console.WriteLine("Adulto");
                    break;
                default:
                    Console.WriteLine("Idoso");
                    break;
            }
        }
    }
}