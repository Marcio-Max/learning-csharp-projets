// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           
          Menu();

        }
        static void Soma()
        {
             Console.Clear();

            Console.WriteLine(" Entre com o primeiro valor.");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com o segundo valor");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float Soma = CalcularSoma(valor1,valor2);
            Console.WriteLine($" Resultado da soma de: {valor1} + {valor2} = {Soma}");


            float CalcularSoma(float v1, float v2)
            {
                return (valor1 + valor2);
            }

            Console.ReadKey();
              Menu(); //  Menu() Volta a chamar o Menu apos o fim do calculo da soma.
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine(" Entre com o primeiro valor.");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com o segundo valor");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
             Console.WriteLine($" Resultado da Subtracao = {valor1 - valor2} ");
             Console.ReadKey();
               Menu();
        }
        static void Divisao()
        {
             Console.Clear();

            Console.WriteLine(" Entre com o primeiro valor.");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com o segundo valor");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
             Console.WriteLine($" Resultado da Divisão = {valor1 / valor2} ");
             Console.ReadKey();
               Menu();
        }
        static void Multiplicacao()
        {
             Console.Clear();

            Console.WriteLine(" Entre com o primeiro valor.");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com o segundo valor");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
             Console.WriteLine($" Resultado da Multiplicação = {valor1 * valor2} ");
             Console.ReadKey();
               Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine(" ESCOLHA UMA OPÇÃO!");
            Console.WriteLine("\n 1 - Soma\n 2 - Subtração\n 3 - Divisão\n 4 - Multiplicação\n 5 - Sair ");
            Console.WriteLine("------------------\t");
            short opcao = short.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: Soma();  break;
                    case 2: Subtracao(); break;   
                    case 3: Divisao();  break;
                    case 4: Multiplicacao();  break;
                    case 5:
                         Console.WriteLine(" Obrigado ate a proxima!!!");
                         System.Environment.Exit(0);
                    break;
/*Mesmo que else*/  default:
                        Console.WriteLine(" Opcao invalida ecolha de novo!");
                        Menu(); // caso nao escolher nenhuma das opcoes existente volta a chamar o Menu novamente
                    break;
                }


            Console.ReadKey();
        }
    
    }

    
}

