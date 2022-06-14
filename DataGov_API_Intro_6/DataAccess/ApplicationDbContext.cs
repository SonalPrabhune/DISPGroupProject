using Microsoft.EntityFrameworkCore;
using Project_College_Scorecard.Models;
namespace Project_College_Scorecard.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        { }
        public DbSet<AllColleges> allColleges { get; set; }
        
        public DbSet<CollegeResult> collegeResult { get; set; }

        public DbSet<Latest> latest { get; set; }
        
        public DbSet<School> schools { get; set; }
        
    }
}
