using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserLoginBE.Entities.Models;

namespace UserLoginBE.Entities.Configurations
{
    public class WardConfiguration : IEntityTypeConfiguration<Ward>
    {
        public void Configure(EntityTypeBuilder<Ward> builder)
        {
            builder.HasKey(x => x.WardId);
            builder.Property(x => x.WardName).IsRequired();
            builder.Property(x => x.DistrictName).IsRequired();
         
        }
    }
}
