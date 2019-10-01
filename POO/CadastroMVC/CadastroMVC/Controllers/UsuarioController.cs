using System;
using System.Collections.Generic;
using CadastroMVC.Models;

namespace CadastroMVC.Controllers
{

    /// <summary>
    /// Método para cadastro de usuários
    /// </summary>

    public class UsuarioController
    {
        List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
        public void CadastroUsuario()
        {
            // Cadastrando nome 
            Console.WriteLine("Informe o seu nome:");
            string nome = Console.ReadLine();
            // Cadastrando e-mail
            Console.WriteLine("Informe o seu E-mail:");
            string email = Console.ReadLine();
            // Cadastrando senha
            Console.WriteLine("Informe sua senha:");
            string senha = Console.ReadLine();
            // Instanciando um novo usuário  
            UsuarioModel usuario = new UsuarioModel();
            // Copulando as caracteristicas     ao objeto 
            usuario.Id = listaDeUsuarios.Count + 1;
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add(usuario);

        }// Fim cadastro do usuário

        public void ListarUsuario()
        {
            foreach (var item in listaDeUsuarios)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"Usuario: {item.Nome} ");
                Console.WriteLine($"Id: {item.Id}");
                Console.WriteLine($"E-mail: {item.Email}");
                Console.WriteLine($"Data do Cadastro: {item.DataCriacao}");
                Console.WriteLine("-------------------------------------");
            }
        }
        public bool Logar()
        {

            Console.WriteLine("Informe o seu e-email");
            string email = Console.ReadLine();

            Console.WriteLine("Insira sua senha:");
            string senha = Console.ReadLine();

            foreach (var item in listaDeUsuarios)
            {
                if (item.Email == email && item.Senha == senha)
                {
                    return true;
                    
                }
            }// Fim foreach
            return false;
        }// Fim logar 
    }
}