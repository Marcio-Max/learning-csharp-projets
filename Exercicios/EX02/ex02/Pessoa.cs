using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex02
{
    public class Pessoa
    {
        public double peso, altura;

        public double calcularIMC()
        {
            return (peso / (altura * altura));
        }

        public string situacao(double imc)
        {
            string retorno;
           
            if(imc < 18.5)
            {
               retorno = "Abaixo do peso";
            }
            else if(imc < 25)
            {
                retorno=   "Peso Normal";
            }
            else if(imc < 30)
            {
                retorno=" Acima do peso";
            }
            else if(imc < 35)
            {
                retorno =" Obesidade Grau I ";
            }
            else if(imc < 40)
            {
                retorno = " Obesidade Grau II";
            }
            else
            {
                retorno = "Obesidade grau III";
            }
          
          return retorno;
        }

        public void mensagemExibirCalculoSituacao()
        { 
            //obter calculo da IMC
           double obterIMC = calcularIMC();

           //obter a situcao (string)
           string obterSituacao = situacao(obterIMC);

           //Mensagem
           Console.WriteLine($" O seu IMC e {obterIMC} e a Situacao {obterSituacao} \n ");
        }
    }
}