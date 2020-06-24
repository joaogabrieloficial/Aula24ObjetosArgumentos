using System;

namespace Aula24ObjetosArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

             Produto p1 =new Produto(1,"Euro Truck 2", 37.32f);
             Produto p2 =new Produto(2,"Shadow warrior", 59.34f);
             Produto p3 =new Produto(3,"Black desert", 60.99f);
             Produto p4 =new Produto(4,"Minecraft", 40f);

             cart.Adicionar(p1);
             cart.Adicionar(p2);
             cart.Adicionar(p3);
             cart.Adicionar(p4);

             cart.RemoverProduto(p4);

           

             cart.ler();
             cart.MostrarTotal();


        }
    }
}
