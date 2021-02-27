using Minha1Conexao.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minha1Conexao.Domain.Model
{
    public class Turma : IEntity
    {

        public Guid Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public List<TurmaProfessor> TurmaProfessor { get; set; }
        public List<TurmaAluno> TurmaAluno { get; set; }

    }
}
