using DesafioSimpress.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskSimpress.Entities.Mapeamento
{
    public class MapeamentoProduto : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder) 
        {
            builder.ToTable("Produto");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(255);

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(255);

            builder.Property(x => x.Ativo)
                .HasColumnName("Ativo");

            builder.Property(x => x.Perecivel)
                .HasColumnName("Perecivel");

            builder.HasOne(x => x.Categoria)
                .WithMany()
                .HasForeignKey(p=> p.CategoriaId)
                .HasConstraintName("FK_Produto_CategoriaProduto_CategoriaId");
                
        }
    }
}
