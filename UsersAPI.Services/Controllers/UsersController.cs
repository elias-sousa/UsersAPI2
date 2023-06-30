using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UsersAPI.Services.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Adicionar Conta de Usuário
        /// </summary>
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Adicionar()
        {
            return Ok();
        }
        /// <summary>
        /// Atualizar dados de Conta de do Usuário
        /// </summary>
        /// 
        [HttpPut]
        public IActionResult Atualizar()
        {
            return Ok();
        }

        /// <summary>
        /// Deletar Conta de Usuário
        /// </summary>
        [HttpDelete]
        public IActionResult Deletar()
        {
            return Ok();
        }

        /// <summary>
        /// Lista todos de Contas de usuários
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok();
        }

    }
}
