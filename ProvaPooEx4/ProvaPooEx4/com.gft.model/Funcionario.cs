using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPooEx4.com.gft.model
{
    abstract class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        protected Funcionario(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        protected Funcionario()
        { }

        //Métodos
        public virtual double Bonificacao() //colocar virtual na classe mãe para poder fazer polimorfismo nas filhas
        {
            return Salario;
        }
    }
}
