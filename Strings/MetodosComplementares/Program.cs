using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var texto = "Este e um texto teste.";
           Console.WriteLine(texto.ToLower());
           Console.WriteLine(texto.ToUpper());
           Console.WriteLine(texto.Insert(5, "AQUI "));//Apartir do indeci 5 colocar a string "AQUI"
           Console.WriteLine(texto.Remove(5,5));//A partir do indeci 5 remover 5 elementos
           Console.WriteLine(texto.Length);
           Console.WriteLine(texto.Replace("Este","isto"));
           //Console.WriteLine(texto.Replace("este","isto"));//Cuidado com  case sensitive
           Console.WriteLine(texto.Replace("e","X"));
           Console.WriteLine(texto.Replace("xxxxx","X"));//si a palvra nao exite logo nao e possivel substituir
Console.WriteLine("=================");
           var divisao = texto.Split(" "); //Devide o testo a onde tem um (" ") e quebra a linha
           Console.WriteLine(divisao[0]); //Imprime as posicoes do Array resultante
           Console.WriteLine(divisao[1]);
           Console.WriteLine(divisao[2]);
           Console.WriteLine(divisao[3]);
           Console.WriteLine(divisao[4]);


           var resultado = texto.Substring(5,10);//A partir da posicao[5] peque mais 10 Posicoes. 
           Console.WriteLine(resultado);

             var texto2 = " Este e um texto teste. ";
             var palavras = texto2;
             Console.WriteLine(palavras);
             palavras = texto2.Trim(); //Trim() remove os epacos no inicio e no fim de uma string
             Console.WriteLine(palavras);


        }
    }
}
