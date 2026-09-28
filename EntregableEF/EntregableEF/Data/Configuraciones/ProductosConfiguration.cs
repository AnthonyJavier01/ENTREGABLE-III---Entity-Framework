using EntregableEF.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntregableEF.Data.Configuraciones
{
    public class ProductosConfiguration : IEntityTypeConfiguration<Productos>
    {
        public void Configure(EntityTypeBuilder<Productos> builder)
        {
            builder.ToTable("Productos");

            builder.HasKey(x => x.ProductoId);

            builder.Property(x => x.ProductoId)
            .ValueGeneratedOnAdd();

            builder.Property(x => x.Nombre)
            .HasMaxLength(150)
            .IsRequired();

            builder.Property(x => x.Precio)
            .HasColumnType("decimal(10,2)")
            .IsRequired();

            builder.Property(x => x.Stock)
            .IsRequired();

            builder.Property(x => x.Created)
            .HasDefaultValueSql("GETDATE()");

            builder.HasOne<Categorias>()
            .WithMany()
            .HasForeignKey(x => x.CategoriaId)
            .HasConstraintName("FK_Productos_Categorias");

            builder.HasIndex(x => x.CategoriaId)
            .HasDatabaseName("IX_Productos_CategoriaId");
        }
    }
}
