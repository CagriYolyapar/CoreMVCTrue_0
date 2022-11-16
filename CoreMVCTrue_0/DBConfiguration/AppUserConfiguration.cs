using CoreMVCTrue_0.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCTrue_0.DBConfiguration
{
    public class AppUserConfiguration:BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.ToTable("Kullanıcılar");
            builder.HasOne(x => x.Profile).WithOne(x => x.AppUser).HasForeignKey<UserProfile>(x => x.ID);
        }
    }
}
