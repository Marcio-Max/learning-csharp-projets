using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX07
{
    public class Produto
    {
        /*
           public     ->  Atributos e métodos VISÍVEIS  em qualquer classes.
           private    ->  Atributos e métodos VISÍVEIS APENAS  na classe em que sao criadas.
           protected  ->  Atributos e métodos VISÍVEIS em classes onde sao CRIADAS OU HERDADAS.
        */
        public string nome;
        private double valor;
    }
}