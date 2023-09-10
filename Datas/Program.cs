
using System;

namespace Datas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            
            var data = new DateTime(); //DateTime e um Struct por isso e sempre inicializado com valores 
            Console.WriteLine($"\nDados da strut DateTime(): {data} \n");

            var dataAtual = DateTime.Now;
            Console.WriteLine($"Data Atual: {dataAtual}");
            Console.WriteLine($"Dia da semana: {dataAtual.DayOfWeek}");

            var dataDefenidoManualmente = new DateTime(2023, 12, 25, 12, 30, 10); //Criando uma data
            Console.WriteLine($"Data Defenida Manualmente: {dataDefenidoManualmente}\n");
            Console.WriteLine(dataDefenidoManualmente.Hour);
            Console.WriteLine(dataDefenidoManualmente.Minute);
            Console.WriteLine(dataDefenidoManualmente.Second);
            Console.WriteLine(dataDefenidoManualmente.DayOfWeek);
            Console.WriteLine(dataDefenidoManualmente.DayOfYear);

            //Formatando Datas usando - string.Format()
            var data01 = DateTime.Now;
            var texto = "Data formatada";
            var dataFormatada = string.Format("{0: yyyy-MM-dd }", data01); //Zero (0) referi-se a variavel data01
            Console.WriteLine(dataFormatada); 

            var dataFormatada03 = string.Format("{0} {1: yyyy-MM-dd }",texto, data01); //Zero (0) referi-se a variavel texto e (1) a variavel data01
            Console.WriteLine(dataFormatada03); 

            var dataFormatada01 = string.Format("{0: yy/MM/dd hh:mm:ss}", data01);
            Console.WriteLine(dataFormatada01); 
            var dataFormatada02 = string.Format("{0: yyyy * MM * dd }", data01);
            Console.WriteLine(dataFormatada02); 
            var dataFormatada04 = string.Format("{0:r}", data01);//Formatacao  (r, s, u) sao as mas usadas
            Console.WriteLine(dataFormatada04); 
            



        }
    }
}