using Microsoft.AspNetCore.Mvc;
using DusiacademyAPI.ENTITIES;
namespace DusiacademyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        //  [HttpGet] //obter
        //   [HttpPost] // Criar
        //   [HttDelete] // Deletar
        //   [HttpPut] //Editar

        [HttpPost(Name = "CreateAluno")]
        public ActionResult CreateAluno (ALUNO aluno)
        {
            return Ok();

        }





    }

}

    
