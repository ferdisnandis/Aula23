using System;
using System.Collections.Generic;


namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando a lista 
            List<Produto> produtos = new List<Produto>();

            //Adicionamos produtos com instância básica
            Produto iphone = new Produto();
            iphone.Codigo = 1;
            iphone.Nome = "Iphone X";
            iphone.Preco = 8700.99f;

            produtos.Add(iphone);

            //Adicionamos produtos através de intâncias ccom construtores
            produtos.Add(new Produto(2, "Apple Watch", 3250.99f));
            produtos.Add(new Produto(3, "Xiaomi", 3000.99f));
            produtos.Add(new Produto(4, "Galaxy A10", 2700.99f));
            produtos.Add(new Produto(5, "Motorola G8", 2000.98f));

            //Mostrar produtos 
                System.Console.WriteLine("Produtos e preços no estoque:");
            foreach(Produto p in produtos){
                Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
            }

            //Deletar com índice de Array
            produtos.RemoveAt(3);
            //Tiramos Xiaomi da lista

            //Deletar com expressão lambda
            produtos.RemoveAll(x => x.Nome == "Apple Watch");
            //Tiramos Apple Watch

            Console.WriteLine("\nLista alterada do estoque: ");
            foreach(Produto p in produtos){
            Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
            }


            System.Console.WriteLine();
            List<Cartao> cartao = new List<Cartao>();
            //Adicionar cartões
            cartao.Add(new Cartao("Fernanda Carvalho", 248657913, "Visa", 12, 666));
            cartao.Add(new Cartao("Fernando Carvalho", 123456789, "Mastercard", 08, 999));
            cartao.Add(new Cartao("Adnanref Carvalho", 987654321, "Mastercard", 10, 666));
            cartao.Add(new Cartao("Odnanref Carvalho", 147258369, "Visa", 05, 777));

            //Mostrar Cartões
            System.Console.WriteLine("Cartões Cadastrados: ");
            foreach(Cartao c in cartao){
                Console.WriteLine($"{c.Titular} {c.Numero} {c.Bandeira} {c.Vencimento} {c.CVV}");
            }

             //Deletar com expressão lambda
            cartao.RemoveAll(x => x.Bandeira == "Visa");
            //Tiramos todos os cartões Visa

            System.Console.WriteLine();
            System.Console.WriteLine("Cartões Cadastrados Alterados: ");
            foreach(Cartao c in cartao){
                Console.WriteLine($"{c.Titular} {c.Numero} {c.Bandeira} {c.Vencimento} {c.CVV}");
            }








        }
    }
}
