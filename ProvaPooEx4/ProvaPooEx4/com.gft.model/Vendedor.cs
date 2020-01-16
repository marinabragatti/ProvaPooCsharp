using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPooEx4.com.gft.model
{
    class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario)
        {

        }
        public override double Bonificacao()
        {
            Salario += 3000;
            return Salario;
        }
    }
}
