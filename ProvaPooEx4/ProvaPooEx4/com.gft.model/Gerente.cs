using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPooEx4.com.gft.model
{
    class Gerente : Funcionario
    {
        //Construtor
        public Gerente(string nome, int idade, double salario) :base(nome, idade, salario)
        {

        }

        //Método

        public override double Bonificacao()
        {
            Salario += 10000;
            return Salario;
        }
    }
}
