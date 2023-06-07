using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;
using TaskWebAPI.Entities;

namespace TaskWebAPI.DAL.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(p => p.DailyPrice)
                .IsRequired();
            builder.Property(c=>c.Description)
                .HasColumnType(SqlDbType.NVarChar.ToString())
                .IsRequired();
            builder.Property(a=>a.ModelYear)
                .HasColumnType(SqlDbType.Int.ToString())
                .IsRequired();
            

        }
    }
}
