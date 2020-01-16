using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPooEx4.com.gft.model
{
    class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario)
        {

        }
        public override double Bonificacao()
        {
            Salario += 5000;
            return Salario;
        }
    }
}
