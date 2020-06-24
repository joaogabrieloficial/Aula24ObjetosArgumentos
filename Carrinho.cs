using System;
using System.Collections.Generic;

namespace Aula24ObjetosArgumentos
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }
        
        List<Produto> carrinho = new List<Produto>();


        public void Adicionar(Produto _produto){

            carrinho.Add(_produto);
        }
        public void RemoverProduto(Produto _produto){
            carrinho.Remove(_produto);
        }

        public void ler(){
            foreach(Produto item in carrinho){
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
                
            }
        }

        public void MostrarTotal(){
            foreach(Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            Console.ForegroundColor =ConsoleColor.Green;
            Console.WriteLine($"Total dos intens: R${ValorTotal}");
            Console.ResetColor();
        }
    }
}