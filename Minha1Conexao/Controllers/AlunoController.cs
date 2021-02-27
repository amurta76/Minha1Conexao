using Microsoft.AspNetCore.Mvc;
using Minha1Conexao.Data.Repository;
using Minha1Conexao.Domain.Model;
using System;
using System.Collections.Generic;

namespace Minha1Conexao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoRepository repo;

        public AlunoController()
        {
            repo = new AlunoRepository();
        }

        [HttpGet("{id}")]
        public Aluno Get(Guid id)
        {
            return repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Aluno> Post([FromBody] Aluno aluno)
        {
            repo.Incluir(aluno);
            return repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Aluno> Put(Guid id, [FromBody] Aluno aluno)
        {
            if (id.Equals(aluno.Id))
                repo.Alterar(aluno);
            return repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Aluno> Delete(Guid id)
        {
            repo.Excluir(id);
            return repo.SelecionarTudo();
        }
    }
}
