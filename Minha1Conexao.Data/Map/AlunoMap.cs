using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Minha1Conexao.Domain.Model;

namespace Minha1Conexao.Data.Map
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Nome).HasColumnType("varchar(150)").IsRequired();

            builder.Property(x => x.Ativo).IsRequired();

        }       
    }
}
