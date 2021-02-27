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
    public class TurmaProfessorController : ControllerBase
    {

        private readonly TurmaProfessorRepository repo;

        public TurmaProfessorController()
        {
            repo = new TurmaProfessorRepository();
        }

        [HttpGet("{id}")]
        public TurmaProfessor Get(Guid id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<TurmaProfessor> Post([FromBody] TurmaProfessor turmaProfessor)
        {
            repo.Incluir(turmaProfessor);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<TurmaProfessor> Put(Guid id, [FromBody] TurmaProfessor turmaProfessor)
        {
            if (id.Equals(turmaProfessor.Id))
                repo.Alterar(turmaProfessor);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<TurmaProfessor> Delete(Guid id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
