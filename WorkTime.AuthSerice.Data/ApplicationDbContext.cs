using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace WorkTime.AuthSerice.Data
{
    //public class ApplicationDbContext: IdentityDbContext<AppUser, AppRole, Guid>
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<AppUser>(entity =>
        //    entity.ToTable(name: "Users"));

        //    //builder.Entity<AppRole>(entity =>
        //    //entity.ToTable(name: "Roles"));
        //    builder.Entity<IdentityRole>(entity =>
        //    entity.ToTable(name: "Roles"));

        //    builder.Entity<IdentityUserRole<Guid>>(entity =>
        //        entity.ToTable(name: "UserRoles"));

        //    builder.Entity<IdentityUserClaim<Guid>>(entity =>
        //        entity.ToTable(name: "UserClaim"));

        //    builder.Entity<IdentityUserLogin<Guid>>(entity =>
        //        entity.ToTable("UserLogins"));

        //    builder.Entity<IdentityUserToken<Guid>>(entity =>
        //        entity.ToTable("UserTokens"));

        //    builder.Entity<IdentityRoleClaim<Guid>>(entity =>
        //        entity.ToTable("RoleClaims"));

        //    builder.ApplyConfiguration(new AppUserConfiguration());
        //}

    }
}
