using EntregableEF.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntregableEF.Data.Configuraciones
{
    public class ClientesConfiguration : IEntityTypeConfiguration<Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(x => x.ClienteId);

            builder.Property(x => x.ClienteId)
            .ValueGeneratedOnAdd();

            builder.Property(x => x.Nombre)
            .HasMaxLength(100)
            .IsRequired();

            builder.Property(x => x.Apellido)
            .HasMaxLength(100)
            .IsRequired();

            builder.Property(x => x.DNI)
            .HasColumnType("char(8)")
            .IsRequired();

            builder.Property(x => x.Email)
            .HasMaxLength(150);

            builder.Property(x => x.Telefono)
            .HasMaxLength(20);

            builder.Property(x => x.Created)
            .HasDefaultValueSql("GETDATE()");

            builder.HasIndex(x => x.DNI)
            .IsUnique();

            builder.HasIndex(x => x.Email)
            .IsUnique();
        }
    }
}
