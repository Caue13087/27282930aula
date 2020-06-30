using System;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Codigo = 8;
            p.Nome = "Gragas";
            p.Preco = 15f;

            p.Inserir(p);

            List<Produto> lista = p.Ler();

            foreach(Produto item in lista){
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"R$:{item.Preco} - {item.Nome}");
            }

            //Buscar por Nome através da expressão lambda
            Produto caue = lista.Find(x => x.Nome == "Gnar");

            System.Console.WriteLine(caue.Nome);

            

            
        }
        
        
    }
}