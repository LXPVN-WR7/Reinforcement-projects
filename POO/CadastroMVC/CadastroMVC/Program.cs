using System;
using CadastroMVC.Controllers;

namespace CadastroMVC
{
    /// <summary>
    /// Cadastro de usuário lista e csv
    /// E autentificação
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {   // Instanciando (criando) o objeto
            UsuarioController usuarioController = new UsuarioController();
            int opcao = 0;

            do
            {
                Console.WriteLine("(1) - Cadastrar Usuário");
                Console.WriteLine("(2) - Listar Usuários");
                Console.WriteLine("(3) - Autentificação");
                Console.WriteLine("(0) - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // Cadastrar
                        usuarioController.CadastroUsuario();
                        break;

                    case 2:
                        // Listar
                        usuarioController.ListarUsuario();
                        break;

                    case 3:
                        // Autentificação Email e Senha
                        bool usuarioRetornado = usuarioController.Logar();
                        if(usuarioRetornado){
                            Console.WriteLine("Bem Vindo a área administrativa");
                            Console.WriteLine("Aqui você que manda");   
                        }else{
                            Console.WriteLine("Usuárion não encontrado");
                        }
                        break;
            
                    case 0:
                        // Sair
                        Console.WriteLine("Tchau!");
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

            } while (opcao != 0);


            // Agora agente chama o método (CadastroUsuario)
            usuarioController.CadastroUsuario();
        }
    }
}
