using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();

            //Array e do tipo (Referenciá type) por isso sempre criamos uma nova instancia dele usando (new)
            int[] numeros = new int[10];//criando um array com 10 posições vazias
            ;

            var meuArray = new int[5] { 1, 2, 3, 4, 5 };  // Igual  int meuArray = new int[5];
            meuArray[0] = 12;
            meuArray[4] = 20;
            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]);


            var teste = new Teste[1] { new Teste() };
            teste[0].iD = true;
            teste[0].nome = "Márcio";
            Console.WriteLine(teste[0].iD);
            Console.WriteLine(teste[0].nome);

        }

        struct Teste
        {
            public bool iD;
            public string nome;
        }
    }

}
