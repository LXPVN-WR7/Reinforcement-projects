using System;
using POO_aula_3.Models;

namespace POO_aula_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo herança");


            FuncionarioModel funcionario = new FuncionarioModel();
            
            List<FuncionarioModel> listaDeFuncionario = new List<FuncionarioModel>();
            
            int opcao;

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("(1) - Cadastrar Funcionário");
                Console.WriteLine("(2) - Executar Ações");
                Console.WriteLine("(0) - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // Caadastrar
                        FuncionarioModel funcionarioCadastrado = funcionario.CadastrarFuncionario();
                        listaDeFuncionario.Add(funcionarioCadastrado);
                        break;

                    case 2:
                        // Exucutar 
                        int acao = 0;
                        do
                        {
                            Console.WriteLine($"Selecione uma ação para {funcionario.name}");
                            Console.WriteLine("(1) - Andar");
                            Console.WriteLine("(2) - Comer");
                            Console.WriteLine("(3) - Trabalhar");
                            Console.WriteLine("(0) - Sair");
                            acao = int.Parse(Console.ReadLine());

                            switch (acao)
                            {
                                case 1:
                                    funcionario.andar();
                                    break;

                                case 2:
                                    funcionario.Comer();
                                    break;

                                case 3:
                                    funcionario.trabalhar();
                                    break;

                                case 0:
                                    Console.WriteLine("Tchau!");
                                    break;

                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }
                        } while (acao != 0);
                        break;

                    case 0:
                        // Sair
                        break;
                    default:
                        // Diferenente de 1, 2 e 0;
                        break;
                }
            } while (opcao != 0);
        }
    }
}

