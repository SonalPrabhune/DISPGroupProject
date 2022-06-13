using Microsoft.EntityFrameworkCore;
using Project_College_Scorecard.Models;
namespace Project_College_Scorecard.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        { }

        //public DbSet<Rootobject> rootobject { get; set; }
        //public DbSet<Metadata> metadata { get; set; }
        //public DbSet<Result> result { get; set; }
        //public DbSet<Latest> latest { get; set; }
        //public DbSet<School> school { get; set; }




        public DbSet<AllColleges> allColleges { get; set; }
        //public DbSet<Metadata> metaData { get; set; }

        
        public DbSet<CollegeResult> collegeResult { get; set; }

        public DbSet<Latest> latest { get; set; }
        //public DbSet<College> colleges { get; set; }

        //public DbSet<School2> school2 { get; set; }
        public DbSet<School> schools { get; set; }
        //public DbSet<Academics> academics { get; set; }
        //public DbSet<CollegePrograms> collegePrograms { get; set; }
        //public DbSet<Assoc> associates { get; set; }
        //public DbSet<Degree> degrees { get; set; }
        //public DbSet<Bachelors> bachelors { get; set; }

    }
}
