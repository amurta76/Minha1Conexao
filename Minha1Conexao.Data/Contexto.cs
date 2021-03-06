﻿using Microsoft.EntityFrameworkCore;
using Minha1Conexao.Data.Map;
using Minha1Conexao.Domain;
using Minha1Conexao.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minha1Conexao.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public DbSet<TurmaProfessor> TurmaProfessor { get; set; }
        public DbSet<TurmaAluno> TurmaAluno { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhos;Database=Alunos;User Id=sa;Password=");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());
            modelBuilder.ApplyConfiguration(new TurmaProfessorMap());
            modelBuilder.ApplyConfiguration(new TurmaAlunoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
