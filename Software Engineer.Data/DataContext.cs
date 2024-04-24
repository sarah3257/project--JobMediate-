using Microsoft.EntityFrameworkCore;
using Software_Engineer.Core.Entities;
namespace Software_Engineer.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Achievements> Achievements { get; set; }
        public int countA { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public int countP { get; set; }
        public DbSet<Office> Office { get; set; }
        public int CountO { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sarahr_db");
        }
     

        //public DataContext()
        //{
        //    Achievements = new List<Achievements>();
        //    Achievements.Add(new Achievements { _idAchievement = 1, _nameAchievement = "תעודת מהט" });
        //    Achievements.Add(new Achievements { _idAchievement = 2, _nameAchievement = "קמא טק" });
        //    countA = 2;
        //    Projects = new List<Projects>();
        //    Projects.Add(new Projects { IdProject = 1, NameProject = "police", CreationDate = new DateTime(2021, 08, 01) });
        //    Projects.Add(new Projects { IdProject = 2, NameProject = "למטייל", CreationDate = new DateTime(2022, 11, 01) });
        //    countP = 2;
        //    Office = new List<Office>();
        //    Office.Add(new Office { _idOffice = 1, _nameOffice = "Google" });
        //    Office.Add(new Office { _idOffice = 2, _nameOffice = "Microsoft" });
        //    countO = 2;
        //}
    }
}
