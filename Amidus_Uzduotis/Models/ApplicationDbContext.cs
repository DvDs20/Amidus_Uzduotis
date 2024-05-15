using Microsoft.EntityFrameworkCore;

namespace Amidus_Uzduotis.Models
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\Deividas\source\repos\Amidus_Uzduotis\DB\ProgrammingLanguageDB.db");
        }

        public DbSet<Language> Languages { get; set; }
    }
}
