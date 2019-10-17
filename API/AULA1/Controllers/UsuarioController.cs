using System.Collections.Generic;
using System.Linq;
using AULA1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AULA1.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]                 // ~ Define a rota de acesso para os métodos desse controller
    [Produces("application/json")]    // ~ Define o tipo de dado transmitido 
    public class UsuarioController : ControllerBase
    {
        List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();

        [HttpGet("listar")]
        public IActionResult Usuarios()
        {
            // ~ Primeiro usuário
            UsuarioModel usuario1 = new UsuarioModel();
            usuario1.usuarioId = 1;
            usuario1.usuarioNome = "Victor Costa";
            usuario1.usuarioEmail = "victor@gmail.com";
            usuario1.usuarioSenha = "ihvebwoc32";

            // ~ Segundo usuário
            UsuarioModel usuario2 = new UsuarioModel();
            usuario2.usuarioId = 2;
            usuario2.usuarioNome = "Paola Oliveirq";
            usuario2.usuarioEmail = "paola@gmail.com";
            usuario2.usuarioSenha = "438yfb";

            // ~ Adicionando a lista
            listaDeUsuarios.Add(usuario1);
            listaDeUsuarios.Add(usuario2);

            return Ok(listaDeUsuarios);
        }
        [HttpGet("listar/{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Usuarios();

            return Ok(listaDeUsuarios.FirstOrDefault(u => u.usuarioId == id)); // Lambda Expression 
        }

        [HttpPost("cadastro")]
        public IActionResult Cadastrar(UsuarioModel usuario)
        {
            Usuarios();
            listaDeUsuarios.Add(usuario);
            return Ok(listaDeUsuarios);
        }
    }
}