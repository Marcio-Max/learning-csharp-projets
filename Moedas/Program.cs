using System;
using System.Globalization;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            //FORMATAÇÃO DE MOEDAS

            //Para trabalhar com moedas, salario, etc, usar o decimal que tem maior precisão mas e maior que double
            //decimal = 12345678901234567890m
            //double = 12345678901234567890d

            decimal preço = 10673.45m;
            Console.WriteLine(preço);

            //Passando/criando uma cultura especifica 
            Console.WriteLine(preço.ToString(CultureInfo.CreateSpecificCulture("en-US")));
            //Console.WriteLine(preço.ToString(CultureInfo.CreateSpecificCulture("en-UK")));

            //Usando formatadores ("C" de curense-moeda) "G" "E04" ("P" para %) "N" "F"...
            Console.WriteLine(preço.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(preço.ToString("C", CultureInfo.CreateSpecificCulture("en-UK")));
            Console.WriteLine(preço.ToString("C", CultureInfo.CreateSpecificCulture("pt-PT")));
            Console.WriteLine(preço.ToString("C", CultureInfo.CreateSpecificCulture("cv-CV")));
            Console.WriteLine(preço.ToString("C", CultureInfo.CreateSpecificCulture("br-BR")));
            Console.WriteLine("----------------");
            //Usando a classe Math e sues métodos para ARREDONDAR um valor decimal

            Console.WriteLine(Math.Round(preço));   // Arredonda para a media(Padrão)
            Console.WriteLine(Math.Ceiling(preço)); // Arredonda para cima
            Console.WriteLine(Math.Floor(preço));   // Arredonda pra baixo


        }
    }
}
