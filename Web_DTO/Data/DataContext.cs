using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Entity.Models;

namespace Web_DTO.Data
{
    public class DataContext : IdentityDbContext<Users, Role, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Maksut12345\SQLEXPRESS02; Database=Web_Project; Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Users_İnformation> Users_İnformation { get; set; }
        public DbSet<AddStory> AddStory { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Player_Values> players { get; set; }
        public DbSet<Martianas_Values> martianas { get; set; }
        public DbSet<PlayerWorldMapTransform> playerWorldMapTransforms { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserLogin<int>>()
                .HasKey(l => new { l.LoginProvider, l.ProviderKey });

            modelBuilder.Entity<Users>()
                .HasOne(u => u.Users_Information)
                .WithOne(ui => ui.Users)
                .HasForeignKey<Users_İnformation>(ui => ui.UserId);

            modelBuilder.Entity<Users_İnformation>()
                .HasOne(ui => ui.Users)
                .WithOne(u => u.Users_Information);
        }
    }
}
