using Microsoft.AspNetCore.Mvc;
using Minha1Conexao.Data.Repository;
using Minha1Conexao.Domain.Model;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Minha1Conexao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {

        private readonly ProfessorRepository repo;

        public ProfessorController()
        {
            repo = new ProfessorRepository();
        }

        [HttpGet("{id}")]
        public Professor Get(Guid id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Professor> Post([FromBody] Professor professor)
        {
            repo.Incluir(professor);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Professor> Put(Guid id, [FromBody] Professor professor)
        {
            if (id.Equals(professor.Id))
                repo.Alterar(professor);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Professor> Delete(Guid id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
