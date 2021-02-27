using Minha1Conexao.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minha1Conexao.Domain.Model
{
   public class TurmaAluno : IEntity
    {

        public Guid Id { get; set; }
        public Guid IdAluno { get; set; }
        public Aluno Aluno { get; set; }
        public Guid IdTurma { get; set; }
        public Turma Turma { get; set; }
    }
}
