using Microsoft.AspNetCore.Mvc;
using DusiacademyAPI.ENTITIES;
using System.Runtime.CompilerServices;

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

        [HttpPost("CreateAluno")]
        public ActionResult CreateAluno(ALUNO aluno)
        {
            if (aluno.idade < 18)
            {
                return Ok(" sucesso");


            }
            else 
            {
                return Ok("necessita de aprovação dos pais");

            }
        }
        [HttpGet(Name = "GetAluno")]
        public ActionResult GetAluno(string Nome)
        {
            var ListaALUNO = new List<ALUNO>();


            var alunoObject1 = new ALUNO();
            alunoObject1.Telefone = 965657998;
            alunoObject1.Idade = 30;
            alunoObject1.Nome = "Junior";
            alunoObject1.Matrícula = 234567;

            var alunoObject2 = new ALUNO();
            alunoObject2.Telefone = 985094268;
            alunoObject2.Idade = 34;
            alunoObject2.Nome = "SId";
            alunoObject2.Matrícula = 283549;

            var alunoObject3 = new ALUNO();
            alunoObject3.Telefone = 923562349;
            alunoObject3.Idade = 27;
            alunoObject3.Nome = "Rodrigo";
            alunoObject3.Matrícula = 203040;

            var alunoObject4 = new ALUNO();
            alunoObject4.Telefone = 923562349;
            alunoObject4.Idade = 27;
            alunoObject4.Nome = "Rodrigo";
            alunoObject4.Matrícula = 203040;

            var alunoObject5 = new ALUNO();
            alunoObject5.Telefone = 923562349;
            alunoObject5.Idade = 27;
            alunoObject5.Nome = "Rodrigo";
            alunoObject5.Matrícula = 203040;




            if (Nome == alunoObject1.Nome)
            {
                return Ok(alunoObject1);

            }


            if (Nome == alunoObject2.Nome)
            {
                return Ok(alunoObject2);

            }

            if (Nome == alunoObject3.Nome)
            {
                return Ok(alunoObject3);

            }

            if (Nome == alunoObject4.Nome)
            {
                return Ok(alunoObject4);

            }

            if (Nome == alunoObject5.Nome)
            {
                return Ok(alunoObject5);

            }

            return Ok("aluno não encontrado");

        } 

           












            //Caso aluno +18 retorno "Aluno cadastrado com sucesso"
            // Se o aluno menor de 18 retorno "Aluno precisa de responsavel"
        
    }
}

    
