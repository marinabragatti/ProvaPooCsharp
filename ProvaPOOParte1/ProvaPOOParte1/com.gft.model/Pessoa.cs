using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOOParte1.com.gft.model
{
    class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

      
        //Construtores
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public Pessoa()
        { }

        

    }
}
