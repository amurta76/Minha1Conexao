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
    public class TurmaController : ControllerBase
    {

        private readonly TurmaRepository repo;

        public TurmaController()
        {
            repo = new TurmaRepository();
        }

        [HttpGet("{id}")]
        public Turma Get(Guid id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Turma> Post([FromBody] Turma turma)
        {
            repo.Incluir(turma);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Turma> Put(Guid id, [FromBody] Turma turma)
        {
            if (id.Equals(turma.Id))
                repo.Alterar(turma);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Turma> Delete(Guid id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
