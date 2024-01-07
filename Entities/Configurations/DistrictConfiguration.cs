using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UserLoginBE.Entities.Models;

namespace UserLoginBE.Entities.Configurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasKey(x => x.DistrictId);
            builder.Property(x => x.DistrictName).IsRequired();
        }
    }

}
