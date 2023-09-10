using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX01
{
    public class Aluno
    {
        //Atributos
        public string nome = "";
        public double nota1, nota2;

        //Metodos

        //Media
        public double Media()
        {
            return (nota1 + nota2) / 2 ;
        }
        //Situacao
        public string Situacao(double media)
        {
            return media >= 7  ?  "Aprovado" : "Reprovado";
        }
        //Mensagem
        public void Mensagem()
        {
             //Obter a media
             double obterMedia = Media();
             //Obter s situacao
             string obterSituacao = Situacao(obterMedia);
             //Mensagem
                Console.WriteLine(" Aluno: "+nome+" esta "+obterSituacao+" Com a media de: "+obterMedia+" valores \n");
        }
    }
}