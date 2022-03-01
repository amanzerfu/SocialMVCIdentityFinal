using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SocialMVCIdentityFinal.Areas.Identity.Data
{
    internal class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(u => u.firstName).HasMaxLength(255);
            builder.Property(u => u.middleName).HasMaxLength(255);
            builder.Property(u => u.lastName).HasMaxLength(255);
            builder.Property(u => u.PhoneNumber).HasMaxLength(255);
            builder.Property(u => u.userAddress).HasMaxLength(255);
            builder.Property(u => u.userJob).HasMaxLength(255);
            builder.Property(u => u.userSex).HasMaxLength(255);
        }
    }
}