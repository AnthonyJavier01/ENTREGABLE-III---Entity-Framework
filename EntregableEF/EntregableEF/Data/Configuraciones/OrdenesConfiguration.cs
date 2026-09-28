using EntregableEF.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntregableEF.Data.Configuraciones
{
    public class OrdenesConfiguration : IEntityTypeConfiguration<Ordenes>
    {
        public void Configure(EntityTypeBuilder<Ordenes> builder)
        {
            builder.ToTable("Ordenes");

            builder.HasKey(x => x.OrdenId);

            builder.Property(x => x.OrdenId)
            .ValueGeneratedOnAdd();

            builder.Property(x => x.FechaOrden)
            .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.Total)
            .HasColumnType("decimal(10,2)");

            builder.Property(x => x.Created)
            .HasDefaultValueSql("GETDATE()");

            builder.HasOne<Clientes>()
            .WithMany()
            .HasForeignKey(x => x.ClienteId)
            .HasConstraintName("FK_Ordenes_Clientes");

            builder.HasIndex(x => x.ClienteId)
            .HasDatabaseName("IX_Ordenes_ClienteId");
        }
    }
}
