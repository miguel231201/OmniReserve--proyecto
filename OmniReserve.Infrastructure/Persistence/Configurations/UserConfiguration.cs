using OmniReserve.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OmniReserve.Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        // 1. Nombre de la tabla
        builder.ToTable("Users");

        // 2. Llave primaria
        builder.HasKey(u => u.Id);

        // 4. Email requerido con longitud máxima de 100
        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(100);

        // 5. Password requerido con longitud máxima de 255
        builder.Property(u => u.FullName)
            .IsRequired()
            .HasMaxLength(150);
    }
}