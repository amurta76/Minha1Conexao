using Minha1Conexao.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minha1Conexao.Domain.Model
{
   public class TurmaProfessor : IEntity
    {

        public Guid Id { get; set; }
        public Guid IdProfessor { get; set; }
        public Professor Professor { get; set; }
        public Guid IdTurma { get; set; }
        public Turma Turma { get; set; }
    }
}
