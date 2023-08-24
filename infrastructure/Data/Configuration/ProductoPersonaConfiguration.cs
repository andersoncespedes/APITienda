using core.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace infrastructure.Data.Configuration
{
    public class ProductoPersonaConfiguration : IEntityTypeConfiguration<ProductoPersona>
    {
        public void Configure(EntityTypeBuilder<ProductoPersona> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("productopersona");
        }
    }
}