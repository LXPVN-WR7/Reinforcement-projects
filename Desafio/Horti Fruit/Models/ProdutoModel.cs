using System;

namespace Horti_Fruit.Models
{
    public class ProdutoModel
    {
        public string Name {get; set;}

        public int Id {get; set;}

        public string Categoria {get; set;}

        public double Preco {get; set;}

        public int Amount {get; set;}

        public DateTime DataCadastro {get; set;}

    }
}