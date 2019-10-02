using System;
using System.Collections.Generic;
using Horti_Fruit.Models;

namespace Horti_Fruit.Controllers
{

    /// <summary>
    ///  Método para cadastro de produtos
    /// </summary>
    public class ProdutoController
    {

        List<ProdutoModel> listaDeProdutos = new List<ProdutoModel>();

        public void CadastroProduto()
        {

            Console.WriteLine("Informe o nome do produto:");
            string name = Console.ReadLine();

            Console.WriteLine("Informe a categoria do produto:");
            string categoria = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto:");
            double preco = double.Parse(Console.ReadLine());
    
            Console.WriteLine("Informe a quantidade total do produto:");
            int amount = int.Parse(Console.ReadLine());

            ProdutoModel produto = new ProdutoModel();

            produto.Name = name;
            produto.Id = listaDeProdutos.Count + 1;
            produto.Categoria = categoria;
            produto.Preco = preco;
            produto.Amount = amount;

            listaDeProdutos.Add(produto); 

            Console.WriteLine("Produtoo Cadastrado");


        }
    }
}