using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_College_Scorecard.Models
{
    public class AllColleges
    {
        [Key]
        public int id { get; set; }
        public List<CollegeResult> results { get; set; }
    }

    public class CollegeResult
    {
        [Key]
        public Guid collegeResultId { get; set; }
        
        public int id { get; set; }
        public Latest latest { get; set; }
        public AllColleges allColleges { get; set; }
    }

    public class Latest
    {
        [Key]
        public Guid latestId { get; set; }
        public School school { get; set; }
    }
    public class School
    {
        [Key]
        public int id { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public int tuition_revenue_per_fte { get; set; }
        public int instructional_expenditure_per_fte { get; set; }
    }
}




