using Microsoft.EntityFrameworkCore;
using Web.Net.Core.Models;

namespace Web.Net.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<UserSetting> UserSettings { get; set; }

        public DbSet<Plan> Plans { get; set; }

        public DbSet<Team>Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=web_net_db");
        }
    }
}