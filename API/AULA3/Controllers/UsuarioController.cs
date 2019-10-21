using System.Collections.Generic;
using System.Linq;
using AULA3.Context;
using AULA3.Models;
using Microsoft.AspNetCore.Mvc;

namespace AULA3.Controllers
{
    [ApiController] // ~ Controleo de API 
    [Route("v1/[controller]")] // ~ Rota da sua API 
    [Produces("application/json")]

    /// <summary>
    /// Método para listar os usuários cadastrados 
    /// </summary>
    /// <returns>Retorna os usuários em formato de list</returns>

    public class UsuarioController : ControllerBase
    {
        AULA3Context context = new AULA3Context();

        [HttpGet ("tsk")]

        public IActionResult Listar()
        {
            List<UsuarioModel> listaDeUsuarios = context.TBL_USUARIO.ToList();

            return Ok(listaDeUsuarios);
        }

        /// <summary>
        /// Efetua o cadastro de um usuário
        /// </summary>
        /// <param name="usuario">Recebe um objeto usuário no formato Json</param>
        /// <returns>Retorna 200 para OK</returns>

        [HttpPost("tsk")]
        public IActionResult Cadastrar(UsuarioModel usuario)
        {
            context.TBL_USUARIO.Add(usuario);
            context.SaveChanges();
            return Ok();
        }

        /// <summary>
        /// Efetua a busca de um usuário através do ID
        /// </summary>
        /// <param name="id">Recebe o ID como parametro</param>
        /// <returns>Retorna o usuário com o ID correspondente</returns>

        [HttpGet("{id}")]
        public IActionResult Buscar(int id)
        {

            UsuarioModel usuarioRetornado = context.TBL_USUARIO.FirstOrDefault(x => x.Usr_Id == id);

            return Ok(usuarioRetornado);
        }
    
        [HttpPut]

        public IActionResult Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioRetornadoAntigo = context.TBL_USUARIO.FirstOrDefault(x => x.Usuario_Id == usuario.Usuario_Id);
            if(usuarioRetornadoAntigo == null)
            {
                return NotFound();
            }

            usuarioRetornadoAntigo.Usr_Nome = usuario.Usr_Nome;
            usuarioRetornadoAntigo.Usr_Email = usuario.Usr_Email;
            usuarioRetornadoAntigo.Usr_Senha = usuario.Usr_Senha;

            context.TBL_USUARIO.Update(usuarioRetornadoAntigo);
            context.SaveChanges();

            return Ok();
        }
        [HttpDelete]

        public IActionResult Delete(int id)
        {

            UsuarioModel usuarioRetornado = context.TBL_USUARIO.FirstOrDefault(x => x.Usr_Id == id);

            if(usuarioRetornado == null)
            {
                return NotFound();
            }

            context.TBL_USUARIO.Remove(usuarioRetornado);
            context.SaveChanges();

            return Ok();
        }
    }
}