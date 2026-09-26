using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OmniReserve.Domain.Entities;

namespace OmniReserve.Infrastructure.Persistence.Configurations;

public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        // 1. Nombre de la tabla
        builder.ToTable("Rooms");

        // 2. Llave primaria
        builder.HasKey(r => r.Id);

        // 3. RoomNumber requerido con longitud máxima de 10
        builder.Property(r => r.RoomNumber)
            .IsRequired()
            .HasMaxLength(10);

        // 4. PricePerNight con precisión (18, 2)
        builder.Property(r => r.PricePerNight)
            .HasPrecision(18, 2);

        // 5. Convertir Enum a String para la base de datos
        builder.Property(r => r.Type)
            .HasConversion<string>();
    }
}
