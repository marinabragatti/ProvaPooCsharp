using ProvaPOOParte1.com.gft.model;
using System;
using System.Collections.Generic;


namespace ProvaPOOParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa p1 = new Pessoa("João", 15);
            Pessoa p2 = new Pessoa("Leandro", 21);
            Pessoa p3 = new Pessoa("Paulo", 17);
            Pessoa p4 = new Pessoa("Jessica", 18);

            List<Pessoa> pessoas = new List<Pessoa>
            {
                p1,
                p2,
                p3,
                p4
            };

            int maior = 0;
            String nome = "";

            foreach(Pessoa index in pessoas)
            {
                if (index.Idade > maior)
                {
                    maior = index.Idade;
                    nome = index.Nome;
                }
            }
            Console.WriteLine("---------------------Questão 1---------------------");
            Console.WriteLine("");
            Console.WriteLine("A pessoa mais velha da lista é: {0} com {1} anos de idade.", nome, maior);
            Console.WriteLine("");

            
            Console.WriteLine("---------------------Questão 2---------------------");
            Console.WriteLine("");
            Console.WriteLine("Lista Antes da Exclusão:");
            foreach (Pessoa index in pessoas)
            {
                Console.WriteLine("Nome: {0} - Idade: {1}", index.Nome, index.Idade);
            }

            pessoas.RemoveAll(x => x.Idade < 18);

            Console.WriteLine("");
            Console.WriteLine("Lista Depois da Exclusão:");
            
            //Solução do remove do Luan
            /*foreach (Pessoa index in pessoas.ToArray())
            {
                if (index.Idade < 18) { pessoas.Remove(index); }
            }*/

            foreach (Pessoa index in pessoas.ToArray())
            {
                Console.WriteLine("Nome: {0} - Idade: {1}", index.Nome, index.Idade);
            }

            Console.WriteLine("");
            Console.WriteLine("---------------------Questão 3---------------------");
            Console.WriteLine("");

            foreach (Pessoa index in pessoas.ToArray())
            {
                if (index.Nome == "Jessica")
                    Console.WriteLine("Existe uma pessoa {0} na lista e sua idade é {1} anos", index.Nome, index.Idade);
            }


        }
    }
}
