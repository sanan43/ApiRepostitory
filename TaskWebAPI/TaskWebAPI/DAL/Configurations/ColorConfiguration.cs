using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskWebAPI.Entities;

namespace TaskWebAPI.DAL.Configurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            
        }
    }
}
