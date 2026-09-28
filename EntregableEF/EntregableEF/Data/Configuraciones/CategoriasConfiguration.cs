using EntregableEF.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntregableEF.Data.Configuraciones
{
    public class CategoriasConfiguration : IEntityTypeConfiguration<Categorias>
    {
        public void Configure(EntityTypeBuilder<Categorias> builder)
        {
            builder.ToTable("Categorias");

            builder.HasKey(x => x.CategoriaId);

            builder.Property(x => x.CategoriaId)
            .ValueGeneratedOnAdd();

            builder.Property(x => x.Nombre)
            .HasMaxLength(100)
            .IsRequired();

            builder.Property(x => x.Descripcion)
            .HasMaxLength(250);

            builder.Property(x => x.Created)
            .HasDefaultValueSql("GETDATE()");
        }
    }
}
