using Microsoft.EntityFrameworkCore;
using HavenAtTheCrossroads.Models;

namespace HavenAtTheCrossroads
{
    public class HavenDbContext : DbContext
    {
        public HavenDbContext(
     DbContextOptions<HavenDbContext> options) : base(options) { }

        public DbSet<SessionModel> Sessions { get; set; }
        public DbSet<MonsterModel> Monsters { get; set; }
        public DbSet<SessionItemModel> SessionItems { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<CharacterModel> Characters { get; set; }
    }
}
