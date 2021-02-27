using Minha1Conexao.Domain.Interface;
using Minha1Conexao.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minha1Conexao.Domain.Model
{
   public class Aluno: IEntity
    {
        public Guid Id { get; set; }
        public  String Nome { get; set; }
        public bool Ativo { get; set; }

        public List<TurmaAluno> TurmaAluno { get; set; }


    }
}
