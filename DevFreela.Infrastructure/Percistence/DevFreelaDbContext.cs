using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace DevFreela.Infrastructure.Percistence
{
    public class DevFreelaDbContext : DbContext
    {
        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<ProjectComment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Project>()
                .HasOne(p => p.Client)
                .WithMany();

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Skill>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<UserSkill>()
                .HasKey(us => us.Id);

            modelBuilder.Entity<ProjectComment>()
                .HasKey(pc => pc.Id);
        }
    }
}
