using Extranet.Models;
using Microsoft.EntityFrameworkCore;
namespace Extranet.Data
{
    public class ExtranetDbContext: DbContext
    {
        public ExtranetDbContext(DbContextOptions<ExtranetDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.user_id);
            modelBuilder.Entity<Profile>().HasKey(p => p.profile_id);
            modelBuilder.Entity<User>().HasOne(u => u.profile).WithOne(p => p.user).HasForeignKey<Profile>(p => p.user_id);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}
