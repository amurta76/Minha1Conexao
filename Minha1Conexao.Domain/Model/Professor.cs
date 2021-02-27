using Minha1Conexao.Domain.Interface;
using Minha1Conexao.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minha1Conexao.Domain.Model
{
    public class Professor : IEntity
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public bool Ativo { get; set; }
        public Turno Turno { get; set; }
        public String Banco { get; set; }
        public String Agencia { get; set; }
        public String Conta { get; set; }

        public List<TurmaProfessor> TurmaProfessor { get; set; }

    }


    public enum Turno
    {
        Manhã,
        Tarde,
        Noite,
        Integral
    }
}
