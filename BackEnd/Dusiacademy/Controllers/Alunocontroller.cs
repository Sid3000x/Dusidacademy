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
        public ActionResult CreateAluno(ALUNO aluno)
        {
            if (aluno.Idade < 18)
            {
                return Ok("cadastrado com sucesso");


            }
            else
            {
                return Ok("precisa de responsavel");

            }

        }
            [HttpGet(Name = "GetAluno")]
            public ActionResult GetAluno()
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
                    ListaALUNO.Add(alunoObject1);
                    ListaALUNO.Add(alunoObject2);
                    ListaALUNO.Add(alunoObject3);

                    return Ok(ListaALUNO);



            }

           

            //Caso aluno +18 retorno "Aluno cadastrado com sucesso"
            // Se o aluno menor de 18 retorno "Aluno precisa de responsavel"
        
    }
}

    
