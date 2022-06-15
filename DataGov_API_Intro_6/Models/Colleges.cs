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

        [DataType(DataType.PostalCode)]
        public string zip { get; set; }

        [StringLength(50, ErrorMessage = "City name cannot be longer than 50 characters.")]
        public string city { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "College name cannot be longer than 50 characters.")]
        public string name { get; set; }

        [StringLength(50, ErrorMessage = "State name cannot be longer than 50 characters.")]
        public string state { get; set; }

        [DataType(DataType.Currency)]
        public int tuition_revenue_per_fte { get; set; }

        [DataType(DataType.Currency)]
        public int instructional_expenditure_per_fte { get; set; }
    }
}




