using DesafioSimpress.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskSimpress.Entities.Mapeamento
{
    public class MapeamentoCategoriaProduto : IEntityTypeConfiguration<CategoriaProduto>
    {
        public void Configure(EntityTypeBuilder<CategoriaProduto> builder) 
        {
            builder.ToTable("CategoriaProduto");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(255);

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(255);

            builder.Property(x => x.Ativo)
                .HasColumnName("Ativo");
        }
    }
}
