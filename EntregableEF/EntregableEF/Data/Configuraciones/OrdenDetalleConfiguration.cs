using EntregableEF.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntregableEF.Data.Configuraciones
{
    public class OrdenDetalleConfiguration : IEntityTypeConfiguration<OrdenDetalle>
    {
        public void Configure(EntityTypeBuilder<OrdenDetalle> builder)
        {
            builder.ToTable("OrdenDetalle");

            builder.HasKey(x => x.DetalleId);

            builder.Property(x => x.DetalleId)
            .ValueGeneratedOnAdd();

            builder.Property(x => x.Cantidad)
            .IsRequired();

            builder.Property(x => x.PrecioUnitario)
            .HasColumnType("decimal(10,2)")
            .IsRequired();

            builder.Property(x => x.SubTotal)
            .HasColumnType("decimal(10,2)")
            .IsRequired();

            builder.Property(x => x.Created)
            .HasDefaultValueSql("GETDATE()");

            builder.HasOne<Ordenes>()
            .WithMany()
            .HasForeignKey(x => x.OrdenId)
            .HasConstraintName("FK_OrdenDetalle_Ordenes");

            builder.HasOne<Productos>()
            .WithMany()
            .HasForeignKey(x => x.ProductoId)
            .HasConstraintName("FK_OrdenDetalle_Productos");

            builder.HasIndex(x => x.OrdenId)
            .HasDatabaseName("IX_OrdenDetalle_OrdenId");

            builder.HasIndex(x => x.ProductoId)
            .HasDatabaseName("IX_OrdenDetalle_ProductoId");
        }
    }
}
