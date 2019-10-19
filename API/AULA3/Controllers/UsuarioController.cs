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

    public class UsuarioController : ControllerBase
    {
        AULA3Context context = new AULA3Context();

        [HttpGet("tsk")]

        public IActionResult Listar()
        {
            List<UsuarioModel> listaDeUsuarios = context.TBL_USUARIO.ToList();

            return Ok(listaDeUsuarios);
        }

        [HttpPost("tsk")]
        public IActionResult Cadastrar(UsuarioModel usuario)
        {
            context.TBL_USUARIO.Add(usuario);
            context.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Buscar(int id)
        {

            UsuarioModel usuarioRetornado = context.TBL_USUARIO.FirstOrDefault(x => x.Usr_Id == id);

            return Ok(usuarioRetornado);
        }
    }
}