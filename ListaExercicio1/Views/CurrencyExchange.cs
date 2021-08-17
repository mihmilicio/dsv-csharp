using System;

namespace ListaExercicio1.Views
{
    public static class CurrencyExchange
    {
        /*
         * Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo deve receber o valor em real (R$) e apresentar os valores convertidos em:
            a)	Dólar (1 dólar = 5,17 reais)
            b)	Euro (1 euro = 6,14 reais)
            c)	Peso argentino (1 peso argentino = 0,05 reais)
         */
        
        private const double DollarValue = 5.17;
        private const double EuroValue = 6.14;
        private const double PesoValue = 0.05;

        public static void Exec()
        {
            double real;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Conversor monetário");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Insira o valor em reais (R$): ");
            try
            {
                real = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possível processar o valor inserido. Tente novamente");
                return;
            }

            Console.WriteLine($"Dólar: {FormatCurrency(CalcDollar(real))}");
            Console.WriteLine($"Euro: {FormatCurrency(CalcEuro(real))}");
            Console.WriteLine($"Pesos argentinos: {FormatCurrency(CalcPeso(real))}");
        }

        private static double CalcDollar(double real)
        {
            return real * DollarValue;
        }

        private static double CalcEuro(double real)
        {
            return real * EuroValue;
        }

        private static double CalcPeso(double real)
        {
            return real * PesoValue;
        }

        private static string FormatCurrency(double amount)
        {
            return $"¤ {amount:N2}";
        }
    }
}