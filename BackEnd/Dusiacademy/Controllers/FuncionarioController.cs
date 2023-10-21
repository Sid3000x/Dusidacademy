using Microsoft.AspNetCore.Mvc;
using DusiacademyAPI.ENTITIES;
using System.Runtime.CompilerServices;

namespace DusiacademyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {


        [HttpPost("CreateFuncionario")]
        public ActionResult CreateFuncionario()
        {
            return Ok("encontrado");

        }





        [HttpPost("GetFuncionario")]
        public ActionResult GetFuncionario()
        {
            var ListaFuncionario = new List<Funcionario>();


            var funcionarioObject1 = new Funcionario();
            funcionarioObject1.Telefone = 965657998;
            funcionarioObject1.Idade = 30;
            funcionarioObject1.Nome = "Junior";
            funcionarioObject1.Matrícula = 234567;

            var funcionarioObject2 = new Funcionario();
            funcionarioObject2.Telefone = 985094268;
            funcionarioObject2.Idade = 34;
            funcionarioObject2.Nome = "SId";
            funcionarioObject2.Matrícula = 283549;

            var funcionarioObject3 = new Funcionario();
            funcionarioObject3.Telefone = 923562349;
            funcionarioObject3.Idade = 27;
            funcionarioObject3.Nome = "Rodrigo";
            funcionarioObject3.Matrícula = 203040;

            var funcionarioObject4 = new Funcionario();
            funcionarioObject4.Telefone = 923562349;
            funcionarioObject4.Idade = 27;
            funcionarioObject4.Nome = "Rodrigo";
            funcionarioObject4.Matrícula = 203040;

            var funcionarioObject5 = new Funcionario();
            funcionarioObject5.Telefone = 923562349;
            funcionarioObject5.Idade = 27;
            funcionarioObject5.Nome = "Rodrigo";
            funcionarioObject5.Matrícula = 203040;

            ListaFuncionario.Add(funcionarioObject1);
            ListaFuncionario.Add(funcionarioObject2);
            ListaFuncionario.Add(funcionarioObject3);
            ListaFuncionario.Add(funcionarioObject4);
            ListaFuncionario.Add(funcionarioObject5);


            return Ok(ListaFuncionario);
        }

    }
}