using System.Collections.Generic;
using System.Linq;
using AULA4.Context;
using AULA4.Models;
using Microsoft.AspNetCore.Mvc;

namespace AULA4.Controllers
{

    [ApiController] // ~ Comtreleo de API
    [Route("v1/[controller]")] // ~ Rota da sua API
    [Produces("application/json")]

    /// <summary>
    /// Método para listar usuário cadastrados
    /// </summary>
    /// <returns>Retorna os usuários em formato de list</returns>

    public class UsuarioController : ControllerBase
    {
        AULA4Context context = new AULA4Context();
    
        [HttpGet]
        
        public IActionResult Listar()
        {
            List<UsuarioModel> listaDeUsuarios = context.USUARIO.ToList();
        
            return Ok(listaDeUsuarios);

        }
        
        [HttpPost]

        /// <summary>
        /// Efetua o cadastro de um usuário
        /// </summary>
        /// <param name="usuario">Recebe um objeto usuário no formato Json</param>
        /// <returns>Retorna 200 para OK</returns>

        public IActionResult Cadastrar(UsuarioModel usuario)
        {

            context.USUARIO.Add(usuario);
            context.SaveChanges();
            return Ok();

        }

        [HttpPut]

        public IActionResult Atualizar(UsuarioModel usuario)
        {

            UsuarioModel usuarioAntigo = context.USUARIO.FirstOrDefault(X => X.usr_id == usuario.usr_id);
            if(usuarioAntigo == null)
            {
                return NotFound(); 
            }

            usuarioAntigo.usr_nome = usuario.usr_nome;
            usuarioAntigo.usr_descricao = usuario.usr_descricao;
            usuarioAntigo.usr_data = usuario.usr_data;

            context.USUARIO.Update(usuarioAntigo);
            context.SaveChanges();

            return Ok();
        
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {

            UsuarioModel usuarioAntigo = context.USUARIO.FirstOrDefault(x => x.usr_id == id);

            if(usuarioAntigo == null)
            {
                return NotFound();
            }

            context.USUARIO.Remove(usuarioAntigo);
            context.SaveChanges();

            return Ok();
        }

    }
}