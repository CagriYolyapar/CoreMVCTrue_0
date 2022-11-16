using CoreMVCTrue_0.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCTrue_0.DBConfiguration
{
    public class ProfileConfiguration:BaseConfiguration<UserProfile>
    {
        public override void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            base.Configure(builder);
            builder.ToTable("Kullanıcılar");
        }
    }
}
