using System;
using ex02;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Pessoa a = new Pessoa();
           a.altura = 1.75;
           a.peso = 75.5;
           a.mensagemExibirCalculoSituacao();
        }
    }
}
