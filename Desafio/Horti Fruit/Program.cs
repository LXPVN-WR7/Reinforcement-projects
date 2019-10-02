using System;
using Horti_Fruit.Controllers;

namespace Horti_Fruit
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtoController = new ProdutoController();

            produtoController.CadastroProduto();

        }
    }
}