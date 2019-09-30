using System;
using System.Collections.Generic;

namespace POO_aula_3.Models
{
    // Aqui é aplicado a herança com os : e o nome da Classe  
    public class FuncionarioModel : PessoaModel
    {
        public string cargo { get; set; }

        public List<FuncionarioModel> listaDeFuncionarios = new List<FuncionarioModel>();

        public void trabalhar()
        {
            System.Console.WriteLine("Agora vamos trabalhar!");
        }

        public FuncionarioModel CadastrarFuncionario()
        {
            FuncionarioModel funcionario = new FuncionarioModel();

            Console.WriteLine("Digite o nome do funcionario:");
            funcionario.name = Console.ReadLine();

            Console.WriteLine("Digite a idade do funcionário:");
            funcionario.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Cargo do funcionário:");
            funcionario.cargo = Console.ReadLine();

            return funcionario;
        }
    }
}