using ProvaPooEx4.com.gft.model;
using System;

namespace ProvaPooEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente pessoa1 = new Gerente("João", 20, 3000);
            Supervisor pessoa2 = new Supervisor("Maria", 35, 2000);
            Vendedor pessoa3 = new Vendedor("Adalberto", 30, 1500);

            pessoa1.Bonificacao();
            Console.WriteLine("Salário + bonificação de {0} é de R$ {1}", pessoa1.Nome, pessoa1.Salario);

            pessoa2.Bonificacao();
            Console.WriteLine("Salário + bonificação de {0} é de R$ {1}", pessoa2.Nome, pessoa2.Salario);

            pessoa3.Bonificacao();
            Console.WriteLine("Salário + bonificação de {0} é de R$ {1}", pessoa3.Nome, pessoa3.Salario);
        }
                
    }
}
