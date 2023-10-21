using Microsoft.AspNetCore.Mvc;
using DusiacademyAPI.ENTITIES;
using System.Runtime.CompilerServices;

namespace DusiacademyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogadorController : ControllerBase
    {
        //  [HttpGet] //obter
        //   [HttpPost] // Criar
        //   [HttDelete] // Deletar
        //   [HttpPut] //Editar

        [HttpPost("CreateJogador")]
        public ActionResult CreateJogador(Jogador Jogador)
        {
            if (Jogador.idade < 18)
            {
                return Ok(" sucesso");


            }
            else
            {
                return Ok("necessita treinar mais");

            }
        }
        [HttpGet(Name = "GetJogador")]
        public ActionResult GetJogador(string Nome)
        {
            var ListaJogador = new List<Jogador>();


            var JogadorObject1 = new Jogador();
            JogadorObject1.Telefone = 965657998;
            JogadorObject1.Idade = 30;
            JogadorObject1.Nome = "Junior";
            JogadorObject1.Matrícula = 234567;

            var JogadorObject2 = new Jogador();
            JogadorObject2.Telefone = 985094268;
            JogadorObject2.Idade = 34;
            JogadorObject2.Nome = "SId";
            JogadorObject2.Matrícula = 283549;

            var JogadorObject3 = new Jogador();
            JogadorObject3.Telefone = 923562349;
            JogadorObject3.Idade = 27;
            JogadorObject3.Nome = "Rodrigo";
            JogadorObject3.Matrícula = 203040;

            var JogadorObject4 = new Jogador();
            JogadorObject4.Telefone = 923562349;
            JogadorObject4.Idade = 27;
            JogadorObject4.Nome = "Rodrigo";
            JogadorObject4.Matrícula = 203040;

            var JogadorObject5 = new Jogador();
            JogadorObject5.Telefone = 923562349;
            JogadorObject5.Idade = 27;
            JogadorObject5.Nome = "Rodrigo";
            JogadorObject5.Matrícula = 203040;




            if (Nome == JogadorObject1.Nome)
            {
                return Ok(JogadorObject1);

            }


            if (Nome == JogadorObject2.Nome)
            {
                return Ok(JogadorObject2);

            }

            if (Nome == JogadorObject3.Nome)
            {
                return Ok(JogadorObject3);

            }

            if (Nome == JogadorObject4.Nome)
            {
                return Ok(JogadorObject4);

            }

            if (Nome == JogadorObject5.Nome)
            {
                return Ok(JogadorObject5);

            }

            return Ok("aluno não encontrado");

        }


    }

}