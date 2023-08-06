using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StarterKit.Blazor.WebAssembly.DataAccessLayer.Models;

namespace StarterKit.Blazor.WebAssembly.DataAccessLayer.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Add default admin role to DB
            builder.Entity<IdentityRole<Guid>>().HasData(new IdentityRole<Guid> { Id = new Guid("B01904E5-87C0-435A-892E-27B9ACF2B25F"), Name = "Admin", NormalizedName = "Admin".ToUpper() });
        }

    }
}
