using Microsoft.AspNetCore.Mvc;
using Minha1Conexao.Data.Repository;
using Minha1Conexao.Domain;
using Minha1Conexao.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Minha1Conexao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaAlunoController : ControllerBase
    {

        private readonly TurmaAlunoRepository repo;

        public TurmaAlunoController()
        {
            repo = new TurmaAlunoRepository();
        }

        [HttpGet("{id}")]
        public TurmaAluno Get(Guid id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<TurmaAluno> Post([FromBody] TurmaAluno turmaAluno)
        {
            repo.Incluir(turmaAluno);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<TurmaAluno> Put(Guid id, [FromBody] TurmaAluno turmaProfessor)
        {
            if (id.Equals(turmaProfessor.Id))
                repo.Alterar(turmaProfessor);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<TurmaAluno> Delete(Guid id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
