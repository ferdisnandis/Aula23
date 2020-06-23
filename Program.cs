using System;

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
            produtos.Add(new Produto(3, "Xiaomi", 3250.99f));
            produtos.Add(new Produto(4, "Galaxy A10", 3250.99f));
            produtos.Add(new Produto(5, "Motorola G8", 3250.99f));

            //Mostrar produtos 
            foreach(Produto p in produtos){
                System.Console.WriteLine("Produtos e preços no estoque:");
                Console.WriteLine($"{p.Nome} - R$ {P.Preco}");
            }

            //Deletar com índice de Array
            produtos.RemoveAt(3);
            //Tiramos Xiaomi da lista

            //Deletar com expressão lambda
            produtos.RemoveAll(x => x.Nome == "Apple Watch");
            //Tiramos Apple Watch

            Console.WriteLine("\nLista Alterada: ");
            foreach(Produto p in produtos){
            Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
            }

            

        }
    }
}
