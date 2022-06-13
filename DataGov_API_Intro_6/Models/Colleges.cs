using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_College_Scorecard.Models
{
    //public class Parks
    //{
    //    [Key]
    //    public Guid Id { get; set; }
    //    public int ParksId { get; set; }
    //    public string total { get; set; }
    //    public List<Park> data { get; set; }
    //    public string limit { get; set; }
    //    public int count { get; set; }
    //    public string start { get; set; }
    //}

    //public class Park
    //{
    //    [Key]
    //    public Guid id { get; set; }
    //    public string states { get; set; }
    //    public string longitude { get; set; }
    //    public string directionsInfo { get; set; }
    //    public string directionsUrl { get; set; }
    //    public string url { get; set; }
    //    public string weatherInfo { get; set; }
    //    public string name { get; set; }
    //    public string latLong { get; set; }
    //    public string description { get; set; }
    //    public string designation { get; set; }
    //    public string parkCode { get; set; }
    //    public string fullName { get; set; }
    //    public string latitude { get; set; }
    //    public Parks Parks { get; set; }
    //}

    //public class Rootobject
    //{
    //    public Metadata metadata { get; set; }
    //    public Result[] results { get; set; }
    //}
    public class AllColleges
    {
        [Key]
        public int id { get; set; }
        //public Metadata metadata { get; set; }
        public List<CollegeResult> results { get; set; }
        //public Result[] result { get; set; }
    }

    //public class Metadata
    //{
    //    public int page { get; set; }
    //    public int total { get; set; }
    //    public int per_page { get; set; }
    //}

    //public class Result
    //{
    //    public Latest latest { get; set; }
    //    public School2 school { get; set; }
    //    public Location location { get; set; }
    //    public int id { get; set; }
    //    public string ope6_id { get; set; }
    //    public string ope8_id { get; set; }
    //    public string fed_sch_cd { get; set; }
    //}

    public class CollegeResult
    {
        [Key]
        public Guid collegeResultId { get; set; }
        //public int collegeResultId { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public Latest latest { get; set; }
        //public College college { get; set; }
        //public School2 school { get; set; }
        //public Location location { get; set; }        
        //public string ope6_id { get; set; }
        //public string ope8_id { get; set; }
        //public string fed_sch_cd { get; set; }
        public AllColleges allColleges { get; set; }
    }

    public class Latest
    {
        [Key]
        public Guid latestId { get; set; }
        public School school { get; set; }
        //public Student student { get; set; }
        //public Cost cost { get; set; }
        //public Aid aid { get; set; }
        //public Earnings earnings { get; set; }
        //public Completion completion { get; set; }
        //public Repayment repayment { get; set; }
        //public Admissions admissions { get; set; }
        //public Academics academics { get; set; }
        //public CollegePrograms programs { get; set; }
    }
    //public class College
    //{
    //    [Key]
    //    public Guid collegeId { get; set; }
    //    //public int id { get; set; }
    //    public School school { get; set; }
    //    //public Student student { get; set; }
    //    //public Cost cost { get; set; }
    //    //public Aid aid { get; set; }
    //    //public Earnings earnings { get; set; }
    //    //public Completion completion { get; set; }
    //    //public Repayment repayment { get; set; }
    //    //public Admissions admissions { get; set; }
    //    //public Academics academics { get; set; }
    //    public CollegePrograms collegePrograms { get; set; }
    //}

    public class School
    {
        [Key]
        public int id { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public string name { get; set; }
        //public string alias { get; set; }
        public string state { get; set; }
        public int locale { get; set; }
        //public int dolflag { get; set; }
        //public int branches { get; set; }
        //public int men_only { get; set; }
        public int operating { get; set; }
        public int ownership { get; set; }
        public int region_id { get; set; }
        public string accreditor { get; set; }
        public string school_url { get; set; }
        //public int state_fips { get; set; }
        //public int women_only { get; set; }
        public int main_campus { get; set; }
        public int online_only { get; set; }
        //public Endowment endowment { get; set; }
        //public int carnegie_basic { get; set; }
        public int? faculty_salary { get; set; }
        public int ownership_peps { get; set; }
        public string accreditor_code { get; set; }
        public float? ft_faculty_rate { get; set; }
        //public int carnegie_undergrad { get; set; }
        //public object degree_urbanization { get; set; }
        public int under_investigation { get; set; }
        //public string price_calculator_url { get; set; }
        //public int carnegie_size_setting { get; set; }
        //public Minority_Serving minority_serving { get; set; }
        public int? religious_affiliation { get; set; }
        public int? open_admissions_policy { get; set; }
        //public Title_Iv title_iv { get; set; }
        //public Degrees_Awarded degrees_awarded { get; set; }
        public int tuition_revenue_per_fte { get; set; }
        public int instructional_expenditure_per_fte { get; set; }
        //public Institutional_Characteristics institutional_characteristics { get; set; }
    }

    //public class Endowment
    //{
    //    public int? end { get; set; }
    //    public int? begin { get; set; }
    //}

    //public class Minority_Serving
    //{
    //    public int annh { get; set; }
    //    public int nant { get; set; }
    //    public int aanipi { get; set; }
    //    public int tribal { get; set; }
    //    public int hispanic { get; set; }
    //    public int historically_black { get; set; }
    //    public int predominantly_black { get; set; }
    //}

    //public class Title_Iv
    //{
    //    public string approval_date { get; set; }
    //    public int eligibility_type { get; set; }
    //}

    //public class Degrees_Awarded
    //{
    //    public int highest { get; set; }
    //    public int predominant { get; set; }
    //    public int predominant_recoded { get; set; }
    //}

    //public class Institutional_Characteristics
    //{
    //    public int level { get; set; }
    //}

    //public class Student
    //{
    //    public int size { get; set; }
    //    public int? grad_students { get; set; }
    //    public Enrollment enrollment { get; set; }
    //    public float share_25_older { get; set; }
    //    public float part_time_share { get; set; }
    //    public Demographics demographics { get; set; }
    //    public int FAFSA_applications { get; set; }
    //    public Fafsa_Sent fafsa_sent { get; set; }
    //    public object part_time_share_2000 { get; set; }
    //    public Family_Income family_income { get; set; }
    //    public float share_firstgeneration { get; set; }
    //    public int parents_education_level { get; set; }
    //    public Share_Lowincome share_lowincome { get; set; }
    //    public int valid_dependency_status { get; set; }
    //    public float? students_with_pell_grant { get; set; }
    //    public Share_First share_first { get; set; }
    //    public float share_independent_students { get; set; }
    //    public Share_Highincome share_highincome { get; set; }
    //    public int? undergrads_non_degree_seeking { get; set; }
    //    public Share_Middleincome share_middleincome { get; set; }
    //    public Avg_Dependent_Income avg_dependent_income { get; set; }
    //    public Retention_Rate retention_rate { get; set; }
    //    public Avg_Independent_Income avg_independent_income { get; set; }
    //    public Share_Dependent_Lowincome share_dependent_lowincome { get; set; }
    //    public Share_Independent_Lowincome share_independent_lowincome { get; set; }
    //    public Share_Dependent_Highincome share_dependent_highincome { get; set; }
    //    public Share_Independent_Highincome share_independent_highincome { get; set; }
    //    public Share_Dependent_Middleincome share_dependent_middleincome { get; set; }
    //    public Share_Firstgeneration_Parents share_firstgeneration_parents { get; set; }
    //    public Share_Independent_Middleincome share_independent_middleincome { get; set; }
    //    public int undergrads_with_pell_grant_or_federal_student_loan { get; set; }
    //    public Retention_Rate_Suppressed retention_rate_suppressed { get; set; }
    //    public int ftft_undergrads_with_pell_grant_or_federal_student_loan { get; set; }
    //    public int ftft_undergrads_with_pell_grant_or_federal_student_loan_pooled { get; set; }
    //}

    //public class Enrollment
    //{
    //    public object all { get; set; }
    //    public int? grad_12_month { get; set; }
    //    public int undergrad_12_month { get; set; }
    //}

    //public class Demographics
    //{
    //    public float men { get; set; }
    //    public float women { get; set; }
    //    public float? married { get; set; }
    //    public float? veteran { get; set; }
    //    public int age_entry { get; set; }
    //    public float dependent { get; set; }
    //    public float? female_share { get; set; }
    //    public float? poverty_rate { get; set; }
    //    public float? unemployment { get; set; }
    //    public float first_generation { get; set; }
    //    public int? median_hh_income { get; set; }
    //    public float? over_23_at_entry { get; set; }
    //    public object age_entry_squared { get; set; }
    //    public int avg_family_income { get; set; }
    //    public Race_Ethnicity race_ethnicity { get; set; }
    //    public int median_family_income { get; set; }
    //    public int? median_hh_income_log { get; set; }
    //    public Share_Asian share_asian { get; set; }
    //    public Share_Black share_black { get; set; }
    //    public Share_White share_white { get; set; }
    //    public object avg_family_income_log { get; set; }
    //    public Share_Born_US share_born_US { get; set; }
    //    public Share_Hispanic share_hispanic { get; set; }
    //    public object non_resident_aliens_2000 { get; set; }
    //    public int avg_family_income_independents { get; set; }
    //    public object avg_family_income_independents_log { get; set; }
    //    public Share_Bachelors_Degree_Age25 share_bachelors_degree_age25 { get; set; }
    //    public Share_Professional_Degree_Age25 share_professional_degree_age25 { get; set; }
    //}

    //public class Race_Ethnicity
    //{
    //    public float aian { get; set; }
    //    public float nhpi { get; set; }
    //    public float asian { get; set; }
    //    public float black { get; set; }
    //    public float white { get; set; }
    //    public float unknown { get; set; }
    //    public object api_2000 { get; set; }
    //    public float hispanic { get; set; }
    //    public object aian_2000 { get; set; }
    //    public object black_2000 { get; set; }
    //    public object white_2000 { get; set; }
    //    public float two_or_more { get; set; }
    //    public object unknown_2000 { get; set; }
    //    public object hispanic_2000 { get; set; }
    //    public object aian_prior_2009 { get; set; }
    //    public object black_non_hispanic { get; set; }
    //    public float non_resident_alien { get; set; }
    //    public object white_non_hispanic { get; set; }
    //    public object hispanic_prior_2009 { get; set; }
    //    public object asian_pacific_islander { get; set; }
    //}

    //public class Share_Asian
    //{
    //    public float? home_ZIP { get; set; }
    //}

    //public class Share_Black
    //{
    //    public float? home_ZIP { get; set; }
    //}

    //public class Share_White
    //{
    //    public float? home_ZIP { get; set; }
    //}

    //public class Share_Born_US
    //{
    //    public float? home_ZIP { get; set; }
    //}

    //public class Share_Hispanic
    //{
    //    public float? home_ZIP { get; set; }
    //}

    //public class Share_Bachelors_Degree_Age25
    //{
    //    public float? home_ZIP { get; set; }
    //}

    //public class Share_Professional_Degree_Age25
    //{
    //    public float? home_ZIP { get; set; }
    //}

    //public class Fafsa_Sent
    //{
    //    public object overall { get; set; }
    //    public object _1_college { get; set; }
    //    public object _3_college { get; set; }
    //    public object _2_colleges { get; set; }
    //    public object _4_colleges { get; set; }
    //    public float _2_college_allyrs { get; set; }
    //    public float? _3_college_allyrs { get; set; }
    //    public float? _4_college_allyrs { get; set; }
    //    public object _5_or_more_colleges { get; set; }
    //    public float? _5plus_college_allyrs { get; set; }
    //}

    //public class Family_Income
    //{
    //    public int overall { get; set; }
    //    public int dependent_students { get; set; }
    //    public int independent_students { get; set; }
    //}

    //public class Share_Lowincome
    //{
    //    public float _0_30000 { get; set; }
    //}

    //public class Share_First
    //{
    //    public Time_Full time_full { get; set; }
    //}

    //public class Time_Full
    //{
    //    public float? time { get; set; }
    //}

    //public class Share_Highincome
    //{
    //    public float? _110001plus { get; set; }
    //    public float? _75001_110000 { get; set; }
    //}

    //public class Share_Middleincome
    //{
    //    public float _30001_48000 { get; set; }
    //    public float? _48001_75000 { get; set; }
    //}

    //public class Avg_Dependent_Income
    //{
    //    public int _2014dollars { get; set; }
    //}

    //public class Retention_Rate
    //{
    //    public Overall overall { get; set; }
    //    public Four_Year four_year { get; set; }
    //    public Lt_Four_Year lt_four_year { get; set; }
    //    public Pooled_Yrs_Used pooled_yrs_used { get; set; }
    //    public Cohort cohort { get; set; }
    //}

    //public class Overall
    //{
    //    public float? full_time { get; set; }
    //}

    //public class Four_Year
    //{
    //    public float? full_time { get; set; }
    //    public float? part_time { get; set; }
    //    public float? full_time_pooled { get; set; }
    //    public float? part_time_pooled { get; set; }
    //}

    //public class Lt_Four_Year
    //{
    //    public float? full_time { get; set; }
    //    public float? part_time { get; set; }
    //    public float? full_time_pooled { get; set; }
    //    public float? part_time_pooled { get; set; }
    //}

    //public class Pooled_Yrs_Used
    //{
    //    public int? full_time { get; set; }
    //    public int? part_time { get; set; }
    //}

    //public class Cohort
    //{
    //    public Four_Year1 four_year { get; set; }
    //    public Lt_Four_Year1 lt_four_year { get; set; }
    //}

    //public class Four_Year1
    //{
    //    public int? full_time_pooled { get; set; }
    //    public int? part_time_pooled { get; set; }
    //}

    //public class Lt_Four_Year1
    //{
    //    public int? full_time_pooled { get; set; }
    //    public int? part_time_pooled { get; set; }
    //}

    //public class Avg_Independent_Income
    //{
    //    public int _2014dollars { get; set; }
    //}

    //public class Share_Dependent_Lowincome
    //{
    //    public float? _0_300000 { get; set; }
    //}

    //public class Share_Independent_Lowincome
    //{
    //    public float? _0_30000 { get; set; }
    //}

    //public class Share_Dependent_Highincome
    //{
    //    public float? _110001plus { get; set; }
    //    public float? _75001_110000 { get; set; }
    //}

    //public class Share_Independent_Highincome
    //{
    //    public float? _110001plus { get; set; }
    //    public float? _75001_110000 { get; set; }
    //}

    //public class Share_Dependent_Middleincome
    //{
    //    public float? _48001_75000 { get; set; }
    //    public float? _300001_48000 { get; set; }
    //}

    //public class Share_Firstgeneration_Parents
    //{
    //    public float? highschool { get; set; }
    //    public float somecollege { get; set; }
    //    public float? middleschool { get; set; }
    //}

    //public class Share_Independent_Middleincome
    //{
    //    public float? _30001_48000 { get; set; }
    //    public float? _48001_75000 { get; set; }
    //}

    //public class Retention_Rate_Suppressed
    //{
    //    public Four_Year2 four_year { get; set; }
    //    public Lt_Four_Year2 lt_four_year { get; set; }
    //}

    //public class Four_Year2
    //{
    //    public float? full_time_pooled { get; set; }
    //    public float? part_time_pooled { get; set; }
    //}

    //public class Lt_Four_Year2
    //{
    //    public float? full_time_pooled { get; set; }
    //    public float? part_time_pooled { get; set; }
    //}

    //public class Cost
    //{
    //    public int? booksupply { get; set; }
    //    public Tuition tuition { get; set; }
    //    public Roomboard roomboard { get; set; }
    //    public Title_Iv1 title_iv { get; set; }
    //    public Avg_Net_Price avg_net_price { get; set; }
    //    public Otherexpense otherexpense { get; set; }
    //    public Attendance attendance { get; set; }
    //    public Net_Price net_price { get; set; }
    //    public Program_Reporter2 program_reporter { get; set; }
    //}

    //public class Tuition
    //{
    //    public int? in_state { get; set; }
    //    public int? out_of_state { get; set; }
    //    public int? program_year { get; set; }
    //}

    //public class Roomboard
    //{
    //    public int? oncampus { get; set; }
    //    public int? offcampus { get; set; }
    //}

    //public class Title_Iv1
    //{
    //    public Public _public { get; set; }
    //    public Private _private { get; set; }
    //    public object program_year { get; set; }
    //    public object academic_year { get; set; }
    //    public Program_Reporter program_reporter { get; set; }
    //    public Other_Acad_Calendar other_acad_calendar { get; set; }
    //}

    //public class Public
    //{
    //    public int? all { get; set; }
    //    public By_Income_Level by_income_level { get; set; }
    //}

    //public class By_Income_Level
    //{
    //    public int? _030000 { get; set; }
    //    public int? _110001plus { get; set; }
    //    public int? _3000148000 { get; set; }
    //    public int? _4800175000 { get; set; }
    //    public int? _75001110000 { get; set; }
    //}

    //public class Private
    //{
    //    public int? all { get; set; }
    //    public By_Income_Level1 by_income_level { get; set; }
    //}

    //public class By_Income_Level1
    //{
    //    public int? _030000 { get; set; }
    //    public int? _110001plus { get; set; }
    //    public int? _3000148000 { get; set; }
    //    public int? _4800175000 { get; set; }
    //    public int? _75001110000 { get; set; }
    //}

    //public class Program_Reporter
    //{
    //    public By_Income_Level2 by_income_level { get; set; }
    //}

    //public class By_Income_Level2
    //{
    //    public object _030000 { get; set; }
    //    public object _110001plus { get; set; }
    //    public object _3000148000 { get; set; }
    //    public object _4800175000 { get; set; }
    //    public object _75001110000 { get; set; }
    //}

    //public class Other_Acad_Calendar
    //{
    //    public By_Income_Level3 by_income_level { get; set; }
    //}

    //public class By_Income_Level3
    //{
    //    public object _030000 { get; set; }
    //    public object _110001plus { get; set; }
    //    public object _3000148000 { get; set; }
    //    public object _4800175000 { get; set; }
    //    public object _75001110000 { get; set; }
    //}

    //public class Avg_Net_Price
    //{
    //    public int? _public { get; set; }
    //    public int? overall { get; set; }
    //    public int? _private { get; set; }
    //    public object program_year { get; set; }
    //    public object other_academic_year { get; set; }
    //    public Consumer consumer { get; set; }
    //}

    //public class Consumer
    //{
    //    public int overall_median { get; set; }
    //    public int median_by_pred_degree { get; set; }
    //}

    //public class Otherexpense
    //{
    //    public int? oncampus { get; set; }
    //    public int? offcampus { get; set; }
    //    public int? withfamily { get; set; }
    //}

    //public class Attendance
    //{
    //    public int? program_year { get; set; }
    //    public int? academic_year { get; set; }
    //}

    //public class Net_Price
    //{
    //    public Public1 _public { get; set; }
    //    public Private1 _private { get; set; }
    //    public Consumer1 consumer { get; set; }
    //    public Program_Reporter1 program_reporter { get; set; }
    //    public Other_Acad_Calendar1 other_acad_calendar { get; set; }
    //}

    //public class Public1
    //{
    //    public By_Income_Level4 by_income_level { get; set; }
    //}

    //public class By_Income_Level4
    //{
    //    public int? _030000 { get; set; }
    //    public int? _048000 { get; set; }
    //    public int? _75000plus { get; set; }
    //    public int? _110001plus { get; set; }
    //    public int? _3000148000 { get; set; }
    //    public int? _3000175000 { get; set; }
    //    public int? _4800175000 { get; set; }
    //    public int? _75001110000 { get; set; }
    //}

    //public class Private1
    //{
    //    public By_Income_Level5 by_income_level { get; set; }
    //}

    //public class By_Income_Level5
    //{
    //    public int? _030000 { get; set; }
    //    public int? _048000 { get; set; }
    //    public int? _75000plus { get; set; }
    //    public int? _110001plus { get; set; }
    //    public int? _3000148000 { get; set; }
    //    public int? _3000175000 { get; set; }
    //    public int? _4800175000 { get; set; }
    //    public int? _75001110000 { get; set; }
    //}

    //public class Consumer1
    //{
    //    public By_Income_Level6 by_income_level { get; set; }
    //}

    //public class By_Income_Level6
    //{
    //    public int? _030000 { get; set; }
    //    public int? _048000 { get; set; }
    //    public int? _75000plus { get; set; }
    //    public int? _110001plus { get; set; }
    //    public int? _3000148000 { get; set; }
    //    public int? _3000175000 { get; set; }
    //    public int? _4800175000 { get; set; }
    //    public int? _750001111000 { get; set; }
    //}

    //public class Program_Reporter1
    //{
    //    public By_Income_Level7 by_income_level { get; set; }
    //}

    //public class By_Income_Level7
    //{
    //    public object _030000 { get; set; }
    //    public object _048000 { get; set; }
    //    public object _75000plus { get; set; }
    //    public object _110001plus { get; set; }
    //    public object _3000148000 { get; set; }
    //    public object _3000175000 { get; set; }
    //    public object _4800175000 { get; set; }
    //    public object _75001110000 { get; set; }
    //}

    //public class Other_Acad_Calendar1
    //{
    //    public By_Income_Level8 by_income_level { get; set; }
    //}

    //public class By_Income_Level8
    //{
    //    public object _030000 { get; set; }
    //    public object _048000 { get; set; }
    //    public object _75000plus { get; set; }
    //    public object _110001plus { get; set; }
    //    public object _3000148000 { get; set; }
    //    public object _3000175000 { get; set; }
    //    public object _4800175000 { get; set; }
    //    public object _75001110000 { get; set; }
    //}

    //public class Program_Reporter2
    //{
    //    public Program_1 program_1 { get; set; }
    //    public Program_2 program_2 { get; set; }
    //    public Program_3 program_3 { get; set; }
    //    public Program_4 program_4 { get; set; }
    //    public Program_5 program_5 { get; set; }
    //    public Program_6 program_6 { get; set; }
    //}

    //public class Program_1
    //{
    //    public Cip_6_Digit cip_6_digit { get; set; }
    //}

    //public class Cip_6_Digit
    //{
    //    public int? annualized { get; set; }
    //    public int? full_program { get; set; }
    //}

    //public class Program_2
    //{
    //    public Cip_6_Digit1 cip_6_digit { get; set; }
    //}

    //public class Cip_6_Digit1
    //{
    //    public int? annualized { get; set; }
    //    public int? full_program { get; set; }
    //}

    //public class Program_3
    //{
    //    public Cip_6_Digit2 cip_6_digit { get; set; }
    //}

    //public class Cip_6_Digit2
    //{
    //    public object annualized { get; set; }
    //    public object full_program { get; set; }
    //}

    //public class Program_4
    //{
    //    public Cip_6_Digit3 cip_6_digit { get; set; }
    //}

    //public class Cip_6_Digit3
    //{
    //    public object annualized { get; set; }
    //    public object full_program { get; set; }
    //}

    //public class Program_5
    //{
    //    public Cip_6_Digit4 cip_6_digit { get; set; }
    //}

    //public class Cip_6_Digit4
    //{
    //    public object annualized { get; set; }
    //    public object full_program { get; set; }
    //}

    //public class Program_6
    //{
    //    public Cip_6_Digit5 cip_6_digit { get; set; }
    //}

    //public class Cip_6_Digit5
    //{
    //    public object annualized { get; set; }
    //    public object full_program { get; set; }
    //}

    //public class Aid
    //{
    //    public int? loan_principal { get; set; }
    //    public float pell_grant_rate { get; set; }
    //    public float federal_loan_rate { get; set; }
    //    public int? plus_loan_pct_lower { get; set; }
    //    public int? plus_loan_pct_upper { get; set; }
    //    public int plus_loan_pct_years { get; set; }
    //    public float? ftft_pell_grant_rate { get; set; }
    //    public Cumulative_Debt cumulative_debt { get; set; }
    //    public float? ftft_federal_loan_rate { get; set; }
    //    public Median_Debt median_debt { get; set; }
    //    public float? students_with_any_loan { get; set; }
    //    public Portfolio portfolio { get; set; }
    //    public int? plus_loan_pct_lower_pooled { get; set; }
    //    public int? plus_loan_pct_upper_pooled { get; set; }
    //    public float? ftft_pell_grant_rate_pooled { get; set; }
    //    public Plus_Debt plus_debt { get; set; }
    //    public float? ftft_federal_loan_rate_pooled { get; set; }
    //    public Median_Debt_Suppressed median_debt_suppressed { get; set; }
    //    public int ftft_undergrads_pell_federal_loan_years { get; set; }
    //    public Plus_Debt_Suppressed plus_debt_suppressed { get; set; }
    //}

    //public class Cumulative_Debt
    //{
    //    public int? number { get; set; }
    //    public int? _10th_percentile { get; set; }
    //    public int? _25th_percentile { get; set; }
    //    public int? _75th_percentile { get; set; }
    //    public int? _90th_percentile { get; set; }
    //}

    //public class Median_Debt
    //{
    //    public int? pell_grant { get; set; }
    //    public int? male_students { get; set; }
    //    public int? no_pell_grant { get; set; }
    //    public int? noncompleters { get; set; }
    //    public Income income { get; set; }
    //    public Number number { get; set; }
    //    public int? female_students { get; set; }
    //    public Completers completers { get; set; }
    //    public int? dependent_students { get; set; }
    //    public int? independent_students { get; set; }
    //    public int? first_generation_students { get; set; }
    //    public int? non_first_generation_students { get; set; }
    //}

    //public class Income
    //{
    //    public int? _0_30000 { get; set; }
    //    public int? _30001_75000 { get; set; }
    //    public int? greater_than_75000 { get; set; }
    //}

    //public class Number
    //{
    //    public int? overall { get; set; }
    //    public int? completers { get; set; }
    //    public int? pell_grant { get; set; }
    //    public int? male_students { get; set; }
    //    public int? no_pell_grant { get; set; }
    //    public int? noncompleters { get; set; }
    //    public Income1 income { get; set; }
    //    public int? female_students { get; set; }
    //    public int? dependent_students { get; set; }
    //    public int? independent_students { get; set; }
    //    public int? first_generation_students { get; set; }
    //    public int? non_first_generation_students { get; set; }
    //}

    //public class Income1
    //{
    //    public int? _0_30000 { get; set; }
    //    public int? _30001_75000 { get; set; }
    //    public int? greater_than_75000 { get; set; }
    //}

    //public class Completers
    //{
    //    public int? overall { get; set; }
    //    public float? monthly_payments { get; set; }
    //}

    //public class Portfolio
    //{
    //    public Grad_Plus grad_plus { get; set; }
    //    public Parent_Plus parent_plus { get; set; }
    //    public Direct_Loans direct_loans { get; set; }
    //}

    //public class Grad_Plus
    //{
    //    public int? count { get; set; }
    //    public int? amount { get; set; }
    //}

    //public class Parent_Plus
    //{
    //    public int? count { get; set; }
    //    public int? amount { get; set; }
    //}

    //public class Direct_Loans
    //{
    //    public int count { get; set; }
    //    public long amount { get; set; }
    //}

    //public class Plus_Debt
    //{
    //    public All all { get; set; }
    //    public Male male { get; set; }
    //    public Pell pell { get; set; }
    //    public Not_Male not_male { get; set; }
    //    public Not_Pell not_pell { get; set; }
    //    public Completers1 completers { get; set; }
    //    public Noncompleters noncompleters { get; set; }
    //    public Stafford_Any_School stafford_any_school { get; set; }
    //    public Stafford_This_School stafford_this_school { get; set; }
    //    public Nostafford_Any_School nostafford_any_school { get; set; }
    //    public Nostafford_This_School nostafford_this_school { get; set; }
    //}

    //public class All
    //{
    //    public All_Inst all_inst { get; set; }
    //    public Eval_Inst eval_inst { get; set; }
    //}

    //public class All_Inst
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Eval_Inst
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Male
    //{
    //    public All_Inst1 all_inst { get; set; }
    //    public Eval_Inst1 eval_inst { get; set; }
    //}

    //public class All_Inst1
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Eval_Inst1
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Pell
    //{
    //    public All_Inst2 all_inst { get; set; }
    //    public Eval_Inst2 eval_inst { get; set; }
    //}

    //public class All_Inst2
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Eval_Inst2
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Not_Male
    //{
    //    public All_Inst3 all_inst { get; set; }
    //    public Eval_Inst3 eval_inst { get; set; }
    //}

    //public class All_Inst3
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Eval_Inst3
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Not_Pell
    //{
    //    public All_Inst4 all_inst { get; set; }
    //    public Eval_Inst4 eval_inst { get; set; }
    //}

    //public class All_Inst4
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Eval_Inst4
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Completers1
    //{
    //    public All_Inst5 all_inst { get; set; }
    //    public Eval_Inst5 eval_inst { get; set; }
    //}

    //public class All_Inst5
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public float? median_payment { get; set; }
    //}

    //public class Eval_Inst5
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public float? median_payment { get; set; }
    //}

    //public class Noncompleters
    //{
    //    public All_Inst6 all_inst { get; set; }
    //    public Eval_Inst6 eval_inst { get; set; }
    //}

    //public class All_Inst6
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Eval_Inst6
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Stafford_Any_School
    //{
    //    public All_Inst7 all_inst { get; set; }
    //    public Eval_Inst7 eval_inst { get; set; }
    //}

    //public class All_Inst7
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Eval_Inst7
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Stafford_This_School
    //{
    //    public All_Inst8 all_inst { get; set; }
    //    public Eval_Inst8 eval_inst { get; set; }
    //}

    //public class All_Inst8
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Eval_Inst8
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Nostafford_Any_School
    //{
    //    public All_Inst9 all_inst { get; set; }
    //    public Eval_Inst9 eval_inst { get; set; }
    //}

    //public class All_Inst9
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Eval_Inst9
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Nostafford_This_School
    //{
    //    public All_Inst10 all_inst { get; set; }
    //    public Eval_Inst10 eval_inst { get; set; }
    //}

    //public class All_Inst10
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Eval_Inst10
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //}

    //public class Median_Debt_Suppressed
    //{
    //    public int? overall { get; set; }
    //    public Completers2 completers { get; set; }
    //}

    //public class Completers2
    //{
    //    public int? overall { get; set; }
    //    public float? monthly_payments { get; set; }
    //}

    //public class Plus_Debt_Suppressed
    //{
    //    public Completers3 completers { get; set; }
    //}

    //public class Completers3
    //{
    //    public All_Inst11 all_inst { get; set; }
    //    public Eval_Inst11 eval_inst { get; set; }
    //}

    //public class All_Inst11
    //{
    //    public int? median { get; set; }
    //    public float? median_payment { get; set; }
    //}

    //public class Eval_Inst11
    //{
    //    public int? median { get; set; }
    //    public float? median_payment { get; set; }
    //}

    //public class Earnings
    //{
    //    public object student_count { get; set; }
    //    public _6_Yrs_After_Entry _6_yrs_after_entry { get; set; }
    //    public _10_Yrs_After_Entry _10_yrs_after_entry { get; set; }
    //    public _7_Yrs_After_Entry _7_yrs_after_entry { get; set; }
    //    public _8_Yrs_After_Entry _8_yrs_after_entry { get; set; }
    //    public _9_Yrs_After_Entry _9_yrs_after_entry { get; set; }
    //    public _1_Yr_After_Completion _1_yr_after_completion { get; set; }
    //    public _3_Yrs_After_Completion _3_yrs_after_completion { get; set; }
    //}

    //public class _6_Yrs_After_Entry
    //{
    //    public int median { get; set; }
    //    public float? gt_threshold { get; set; }
    //    public int? male_students { get; set; }
    //    public int female_students { get; set; }
    //    public int? independent_students { get; set; }
    //    public int? median_earnings_male { get; set; }
    //    public float? gt_threshold_suppressed { get; set; }
    //    public int median_earnings_non_male { get; set; }
    //    public int median_earnings_dependent { get; set; }
    //    public float? percent_greater_than_25000 { get; set; }
    //    public float? percent_greater_than_28000 { get; set; }
    //    public Mean_Earnings mean_earnings { get; set; }
    //    public int? median_earnings_independent { get; set; }
    //    public Working_Not_Enrolled working_not_enrolled { get; set; }
    //    public int median_earnings_lowest_tercile { get; set; }
    //    public int? median_earnings_middle_tercile { get; set; }
    //    public int? median_earnings_highest_tercile { get; set; }
    //    public Not_Working_Not_Enrolled not_working_not_enrolled { get; set; }
    //}

    //public class Mean_Earnings
    //{
    //    public int? male_students { get; set; }
    //    public int? lowest_tercile { get; set; }
    //    public int? middle_tercile { get; set; }
    //    public int? female_students { get; set; }
    //    public int? highest_tercile { get; set; }
    //    public int? dependent_students { get; set; }
    //    public int? independent_students { get; set; }
    //    public int? dependent_students_lowest_tercile { get; set; }
    //}

    //public class Working_Not_Enrolled
    //{
    //    public int overall { get; set; }
    //    public int? std_dev { get; set; }
    //    public int? mean_earnings { get; set; }
    //    public int dependent_students { get; set; }
    //    public Income2 income { get; set; }
    //    public Earnings_Percentile earnings_percentile { get; set; }
    //    public int? dependent_students_lowest_tercile { get; set; }
    //}

    //public class Income2
    //{
    //    public int lowest_tercile { get; set; }
    //    public int? middle_tercile { get; set; }
    //    public int? highest_tercile { get; set; }
    //}

    //public class Earnings_Percentile
    //{
    //    public int? _10 { get; set; }
    //    public int? _25 { get; set; }
    //    public int _75 { get; set; }
    //    public int? _90 { get; set; }
    //}

    //public class Not_Working_Not_Enrolled
    //{
    //    public int? overall { get; set; }
    //}

    //public class _10_Yrs_After_Entry
    //{
    //    public int? median { get; set; }
    //    public float? gt_threshold { get; set; }
    //    public int? male_students { get; set; }
    //    public int? female_students { get; set; }
    //    public int? independent_students { get; set; }
    //    public Consumer2 consumer { get; set; }
    //    public float? percent_greater_than_25000 { get; set; }
    //    public float? percent_greater_than_28000 { get; set; }
    //    public Mean_Earnings1 mean_earnings { get; set; }
    //    public Working_Not_Enrolled1 working_not_enrolled { get; set; }
    //    public Median_Earnings median_earnings { get; set; }
    //    public Not_Working_Not_Enrolled1 not_working_not_enrolled { get; set; }
    //}

    //public class Consumer2
    //{
    //    public int overall_median { get; set; }
    //    public int median_by_pred_degree { get; set; }
    //}

    //public class Mean_Earnings1
    //{
    //    public int? male_students { get; set; }
    //    public int? lowest_tercile { get; set; }
    //    public int? middle_tercile { get; set; }
    //    public int? female_students { get; set; }
    //    public int? highest_tercile { get; set; }
    //    public int? dependent_students { get; set; }
    //    public int? independent_students { get; set; }
    //    public int? dependent_students_lowest_tercile { get; set; }
    //}

    //public class Working_Not_Enrolled1
    //{
    //    public int? overall { get; set; }
    //    public int? std_dev { get; set; }
    //    public int? mean_earnings { get; set; }
    //    public int? dependent_students { get; set; }
    //    public Income3 income { get; set; }
    //    public Earnings_Percentile1 earnings_percentile { get; set; }
    //    public int? dependent_students_lowest_tercile { get; set; }
    //}

    //public class Income3
    //{
    //    public int? lowest_tercile { get; set; }
    //    public int? middle_tercile { get; set; }
    //    public int? highest_tercile { get; set; }
    //}

    //public class Earnings_Percentile1
    //{
    //    public int? _10 { get; set; }
    //    public int? _25 { get; set; }
    //    public int? _75 { get; set; }
    //    public int? _90 { get; set; }
    //}

    //public class Median_Earnings
    //{
    //    public int? male_students { get; set; }
    //    public int? lowest_tercile { get; set; }
    //    public int? middle_tercile { get; set; }
    //    public int? highest_tercile { get; set; }
    //    public int? non_male_students { get; set; }
    //    public int? dependent_students { get; set; }
    //    public int? independent_students { get; set; }
    //}

    //public class Not_Working_Not_Enrolled1
    //{
    //    public int? overall { get; set; }
    //}

    //public class _7_Yrs_After_Entry
    //{
    //    public int? std_dev { get; set; }
    //    public int? mean_earnings { get; set; }
    //    public int? working_not_enrolled { get; set; }
    //    public int? not_working_not_enrolled { get; set; }
    //    public float? percent_greater_than_25000 { get; set; }
    //}

    //public class _8_Yrs_After_Entry
    //{
    //    public float? gt_threshold { get; set; }
    //    public int? mean_earnings { get; set; }
    //    public int? std_deviation { get; set; }
    //    public int? median_earnings { get; set; }
    //    public int? median_earnings_male { get; set; }
    //    public int? working_not_enrolled { get; set; }
    //    public int? _10th_percentile_earnings { get; set; }
    //    public int? _25th_percentile_earnings { get; set; }
    //    public int? _75th_percentile_earnings { get; set; }
    //    public int? _90th_percentile_earnings { get; set; }
    //    public int? median_earnings_non_male { get; set; }
    //    public int? not_working_not_enrolled { get; set; }
    //    public int? median_earnings_dependent { get; set; }
    //    public int? working_not_enrolled_male { get; set; }
    //    public float? percent_greater_than_25000 { get; set; }
    //    public float? percent_greater_than_28000 { get; set; }
    //    public int? median_earnings_independent { get; set; }
    //    public int? working_not_enrolled_non_male { get; set; }
    //    public int? median_earnings_lowest_tercile { get; set; }
    //    public int? median_earnings_middle_tercile { get; set; }
    //    public int? working_not_enrolled_dependent { get; set; }
    //    public int? median_earnings_highest_tercile { get; set; }
    //    public int? working_not_enrolled_independent { get; set; }
    //    public int? working_not_enrolled_lowest_tercile { get; set; }
    //    public int? working_not_enrolled_middle_tercile { get; set; }
    //    public int? working_not_enrolled_highest_tercile { get; set; }
    //}

    //public class _9_Yrs_After_Entry
    //{
    //    public int? mean_earnings { get; set; }
    //    public int? std_deviation { get; set; }
    //    public int? working_not_enrolled { get; set; }
    //    public int? not_working_not_enrolled { get; set; }
    //    public float? percent_greater_than_25000 { get; set; }
    //}

    //public class _1_Yr_After_Completion
    //{
    //    public int? overall_count_over_poverty_line { get; set; }
    //    public Working_Not_Enrolled2 working_not_enrolled { get; set; }
    //    public Not_Working_Not_Enrolled2 not_working_not_enrolled { get; set; }
    //}

    //public class Working_Not_Enrolled2
    //{
    //    public int overall_count { get; set; }
    //}

    //public class Not_Working_Not_Enrolled2
    //{
    //    public int overall_count { get; set; }
    //}

    //public class _3_Yrs_After_Completion
    //{
    //    public int overall_count_over_poverty_line { get; set; }
    //    public Working_Not_Enrolled3 working_not_enrolled { get; set; }
    //    public Not_Working_Not_Enrolled3 not_working_not_enrolled { get; set; }
    //}

    //public class Working_Not_Enrolled3
    //{
    //    public int overall_count { get; set; }
    //}

    //public class Not_Working_Not_Enrolled3
    //{
    //    public int overall_count { get; set; }
    //}

    //public class Completion
    //{
    //    public float consumer_rate { get; set; }
    //    public int? pooled_yrs_used { get; set; }
    //    public int? pooled_yrs_used_100 { get; set; }
    //    public int? pooled_yrs_used_200 { get; set; }
    //    public Title_Iv2 title_iv { get; set; }
    //    public Separation_Date separation_date { get; set; }
    //    public _2_Yr_Completion _2_yr_completion { get; set; }
    //    public _3_Yr_Completion _3_yr_completion { get; set; }
    //    public _4_Yr_Completion _4_yr_completion { get; set; }
    //    public _6_Yr_Completion _6_yr_completion { get; set; }
    //    public _8_Yr_Completion _8_yr_completion { get; set; }
    //    public Rate_Suppressed rate_suppressed { get; set; }
    //    public int? pooled_yrs_used_pell_150 { get; set; }
    //    public float? completion_rate_4yr_100nt { get; set; }
    //    public float? completion_rate_4yr_150nt { get; set; }
    //    public float? completion_rate_4yr_200nt { get; set; }
    //    public Outcome_Years outcome_years { get; set; }
    //    public int? completion_cohort_4yr_100nt { get; set; }
    //    public int? completion_cohort_4yr_150nt { get; set; }
    //    public int? completion_cohort_4yr_200nt { get; set; }
    //    public Transfer_Rate transfer_rate { get; set; }
    //    public float? completion_rate_4yr_150_aian { get; set; }
    //    public float? completion_rate_4yr_150_nhpi { get; set; }
    //    public float? completion_rate_4yr_150_asian { get; set; }
    //    public float? completion_rate_4yr_150_black { get; set; }
    //    public float? completion_rate_4yr_150_white { get; set; }
    //    public float? completion_rate_l4yr_150_aian { get; set; }
    //    public int? completion_rate_l4yr_150_nhpi { get; set; }
    //    public int? completion_cohort_4yr_150_aian { get; set; }
    //    public int? completion_cohort_4yr_150_nhpi { get; set; }
    //    public float? completion_rate_l4yr_150_asian { get; set; }
    //    public float? completion_rate_l4yr_150_black { get; set; }
    //    public float? completion_rate_l4yr_150_white { get; set; }
    //    public int? completion_cohort_4yr_150_asian { get; set; }
    //    public int? completion_cohort_4yr_150_black { get; set; }
    //    public int? completion_cohort_4yr_150_white { get; set; }
    //    public float? completion_rate_4yr_150_2ormore { get; set; }
    //    public Outcome_Years_Pell outcome_years_pell { get; set; }
    //    public float? completion_rate_4yr_150_hispanic { get; set; }
    //    public float? completion_rate_4yr_150nt_pooled { get; set; }
    //    public float? completion_rate_4yr_200nt_pooled { get; set; }
    //    public float? completion_rate_l4yr_150_2ormore { get; set; }
    //    public int? completion_cohort_4yr_150_2ormore { get; set; }
    //    public float? completion_rate_l4yr_150_hispanic { get; set; }
    //    public int? completion_cohort_4yr_150_hispanic { get; set; }
    //    public int? completion_cohort_4yr_150nt_pooled { get; set; }
    //    public int? completion_cohort_4yr_200nt_pooled { get; set; }
    //    public float? completion_rate_four_year_150_pell { get; set; }
    //    public object completion_rate_4yr_150_api_pre2010 { get; set; }
    //    public float? completion_rate_less_than_4yr_100nt { get; set; }
    //    public float? completion_rate_less_than_4yr_150nt { get; set; }
    //    public float? completion_rate_less_than_4yr_200nt { get; set; }
    //    public int? completion_cohort_four_year_150_pell { get; set; }
    //    public object completion_rate_4yr_150_aian_pre2010 { get; set; }
    //    public Completion_Rate_4Yr_150_Race completion_rate_4yr_150_race { get; set; }
    //    public float? completion_rate_four_year_100_pooled { get; set; }
    //    public object completion_rate_l4yr_150_api_pre2010 { get; set; }
    //    public object completion_cohort_4yr_150_api_pre2010 { get; set; }
    //    public int? completion_cohort_less_than_4yr_100nt { get; set; }
    //    public int? completion_cohort_less_than_4yr_150nt { get; set; }
    //    public int? completion_cohort_less_than_4yr_200nt { get; set; }
    //    public object completion_rate_4yr_150_black_pre2010 { get; set; }
    //    public object completion_rate_4yr_150_white_pre2010 { get; set; }
    //    public object completion_rate_l4yr_150_aian_pre2010 { get; set; }
    //    public Completion_Rate_L4yr_150_Race completion_rate_l4yr_150_race { get; set; }
    //    public float? completion_rate_lt_four_year_150_pell { get; set; }
    //    public object completion_cohort_4yr_150_aian_pre2010 { get; set; }
    //    public Completion_Cohort_4Yr_150_Race completion_cohort_4yr_150_race { get; set; }
    //    public int? completion_cohort_four_year_100_pooled { get; set; }
    //    public object completion_rate_l4yr_150_black_pre2010 { get; set; }
    //    public object completion_rate_l4yr_150_white_pre2010 { get; set; }
    //    public Outcome_Percentage outcome_percentage { get; set; }
    //    public object completion_cohort_4yr_150_black_pre2010 { get; set; }
    //    public object completion_cohort_4yr_150_white_pre2010 { get; set; }
    //    public int? completion_cohort_lt_four_year_150_pell { get; set; }
    //    public float? completion_rate_lt_four_year_100_pooled { get; set; }
    //    public Outcome_Cohort outcome_cohort { get; set; }
    //    public int? completion_cohort_less_than_4yr_150_aian { get; set; }
    //    public int? completion_cohort_less_than_4yr_150_nhpi { get; set; }
    //    public object completion_rate_4yr_150_hispanic_pre2010 { get; set; }
    //    public int? completion_cohort_less_than_4yr_150_asian { get; set; }
    //    public int? completion_cohort_less_than_4yr_150_black { get; set; }
    //    public int? completion_cohort_less_than_4yr_150_white { get; set; }
    //    public int? completion_cohort_lt_four_year_100_pooled { get; set; }
    //    public Completion_Rate_4Yr_150_Nonresident completion_rate_4yr_150_nonresident { get; set; }
    //    public float? completion_rate_four_year_150_loan_nopell { get; set; }
    //    public float? completion_rate_four_year_150_pell_pooled { get; set; }
    //    public object completion_rate_l4yr_150_hispanic_pre2010 { get; set; }
    //    public Rate_Suppressed_Pell rate_suppressed_pell { get; set; }
    //    public object completion_cohort_4yr_150_hispanic_pre2010 { get; set; }
    //    public Completion_Rate_L4yr_150_Nonresident completion_rate_l4yr_150_nonresident { get; set; }
    //    public float? completion_rate_less_than_4yr_150nt_pooled { get; set; }
    //    public float? completion_rate_less_than_4yr_200nt_pooled { get; set; }
    //    public Completion_Cohort_4Yr_150_Nonresident completion_cohort_4yr_150_nonresident { get; set; }
    //    public int? completion_cohort_four_year_150_loan_nopell { get; set; }
    //    public int? completion_cohort_four_year_150_pell_pooled { get; set; }
    //    public int? completion_cohort_less_than_4yr_150_2ormore { get; set; }
    //    public float? completion_rate_four_year_150_noloan_nopell { get; set; }
    //    public Outcome_Percentage_Pell outcome_percentage_pell { get; set; }
    //    public int? completion_cohort_less_than_4yr_150_hispanic { get; set; }
    //    public int? completion_cohort_less_than_4yr_150nt_pooled { get; set; }
    //    public int? completion_cohort_less_than_4yr_200nt_pooled { get; set; }
    //    public float? completion_rate_lt_four_year_150_loan_nopell { get; set; }
    //    public float? completion_rate_lt_four_year_150_pell_pooled { get; set; }
    //    public Outcome_Cohort_Pell outcome_cohort_pell { get; set; }
    //    public int? completion_cohort_four_year_150_noloan_nopell { get; set; }
    //    public Transfer_Rate_Suppressed transfer_rate_suppressed { get; set; }
    //    public int? completion_cohort_lt_four_year_150_loan_nopell { get; set; }
    //    public int? completion_cohort_lt_four_year_150_pell_pooled { get; set; }
    //    public float? completion_rate_lt_four_year_150_noloan_nopell { get; set; }
    //    public object completion_cohort_less_than_4yr_150_api_pre2010 { get; set; }
    //    public object completion_cohort_less_than_4yr_150_aian_pre2010 { get; set; }
    //    public Completion_Cohort_Less_Than_4Yr_150_Race completion_cohort_less_than_4yr_150_race { get; set; }
    //    public int? completion_cohort_lt_four_year_150_noloan_nopell { get; set; }
    //    public object completion_cohort_less_than_4yr_150_black_pre2010 { get; set; }
    //    public object completion_cohort_less_than_4yr_150_white_pre2010 { get; set; }
    //    public object completion_cohort_less_than_4yr_150_hispanic_pre2010 { get; set; }
    //    public Completion_Cohort_Less_Than_4Yr_150_Nonresident completion_cohort_less_than_4yr_150_nonresident { get; set; }
    //    public Outcome_Percentage_Suppressed outcome_percentage_suppressed { get; set; }
    //    public Outcome_Percentage_Pell_Suppressed outcome_percentage_pell_suppressed { get; set; }
    //}

    //public class Title_Iv2
    //{
    //    public Died_By died_by { get; set; }
    //    public Unknown_By unknown_by { get; set; }
    //    public Completed_By completed_by { get; set; }
    //    public Male1 male { get; set; }
    //    public Withdrawn_By1 withdrawn_by { get; set; }
    //    public Depend depend { get; set; }
    //    public Female female { get; set; }
    //    public Low_Inc low_inc { get; set; }
    //    public Mid_Inc mid_inc { get; set; }
    //    public No_Loan no_loan { get; set; }
    //    public No_Pell no_pell { get; set; }
    //    public High_Inc high_inc { get; set; }
    //    public Independ independ { get; set; }
    //    public First_Gen first_gen { get; set; }
    //    public Still_Enrolled_By10 still_enrolled_by { get; set; }
    //    public Loan_Recip loan_recip { get; set; }
    //    public Pell_Recip pell_recip { get; set; }
    //    public Not_First_Gen not_first_gen { get; set; }
    //    public Transf_Unknown_2Yr_By13 transf_unknown_2yr_by { get; set; }
    //    public Transf_Unknown_4Yr_By13 transf_unknown_4yr_by { get; set; }
    //    public Transf_Completed_2Yr_By13 transf_completed_2yr_by { get; set; }
    //    public Transf_Completed_4Yr_By13 transf_completed_4yr_by { get; set; }
    //    public Transf_Withdrawn_2Yr_By13 transf_withdrawn_2yr_by { get; set; }
    //    public Transf_Withdrawn_4Yr_By13 transf_withdrawn_4yr_by { get; set; }
    //    public Transf_Still_Enrolled_2Yr_By13 transf_still_enrolled_2yr_by { get; set; }
    //    public Transf_Still_Enrolled_4Yr_By13 transf_still_enrolled_4yr_by { get; set; }
    //}

    //public class Died_By
    //{
    //    public object _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Unknown_By
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Completed_By
    //{
    //    public float? _2yrs { get; set; }
    //    public float _3yrs { get; set; }
    //    public float _4yrs { get; set; }
    //    public float _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Male1
    //{
    //    public Died_By1 died_by { get; set; }
    //    public Unknown_By1 unknown_by { get; set; }
    //    public Completed_By1 completed_by { get; set; }
    //    public Withdrawn_By withdrawn_by { get; set; }
    //    public Still_Enrolled_By still_enrolled_by { get; set; }
    //    public Transf_Unknown_2Yr_By transf_unknown_2yr_by { get; set; }
    //    public Transf_Unknown_4Yr_By transf_unknown_4yr_by { get; set; }
    //    public Transf_Completed_2Yr_By transf_completed_2yr_by { get; set; }
    //    public Transf_Completed_4Yr_By transf_completed_4yr_by { get; set; }
    //    public Transf_Withdrawn_2Yr_By transf_withdrawn_2yr_by { get; set; }
    //    public Transf_Withdrawn_4Yr_By transf_withdrawn_4yr_by { get; set; }
    //    public Transf_Still_Enrolled_2Yr_By transf_still_enrolled_2yr_by { get; set; }
    //    public Transf_Still_Enrolled_4Yr_By transf_still_enrolled_4yr_by { get; set; }
    //}

    //public class Died_By1
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Unknown_By1
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Completed_By1
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Withdrawn_By
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Still_Enrolled_By
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Unknown_2Yr_By
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Unknown_4Yr_By
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Completed_2Yr_By
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_4Yr_By
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_2Yr_By
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_4Yr_By
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_2Yr_By
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_4Yr_By
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Withdrawn_By1
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Depend
    //{
    //    public Died_By2 died_by { get; set; }
    //    public Unknown_By2 unknown_by { get; set; }
    //    public Completed_By2 completed_by { get; set; }
    //    public Withdrawn_By2 withdrawn_by { get; set; }
    //    public Still_Enrolled_By1 still_enrolled_by { get; set; }
    //    public Transf_Unknown_2Yr_By1 transf_unknown_2yr_by { get; set; }
    //    public Transf_Unknown_4Yr_By1 transf_unknown_4yr_by { get; set; }
    //    public Transf_Completed_2Yr_By1 transf_completed_2yr_by { get; set; }
    //    public Transf_Completed_4Yr_By1 transf_completed_4yr_by { get; set; }
    //    public Transf_Withdrawn_2Yr_By1 transf_withdrawn_2yr_by { get; set; }
    //    public Transf_Withdrawn_4Yr_By1 transf_withdrawn_4yr_by { get; set; }
    //    public Transf_Still_Enrolled_2Yr_By1 transf_still_enrolled_2yr_by { get; set; }
    //    public Transf_Still_Enrolled_4Yr_By1 transf_still_enrolled_4yr_by { get; set; }
    //}

    //public class Died_By2
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Unknown_By2
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Completed_By2
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Withdrawn_By2
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Still_Enrolled_By1
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Unknown_2Yr_By1
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Unknown_4Yr_By1
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Completed_2Yr_By1
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_4Yr_By1
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_2Yr_By1
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_4Yr_By1
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_2Yr_By1
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_4Yr_By1
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Female
    //{
    //    public Died_By3 died_by { get; set; }
    //    public Unknown_By3 unknown_by { get; set; }
    //    public Completed_By3 completed_by { get; set; }
    //    public Withdrawn_By3 withdrawn_by { get; set; }
    //    public Still_Enrolled_By2 still_enrolled_by { get; set; }
    //    public Transf_Unknown_2Yr_By2 transf_unknown_2yr_by { get; set; }
    //    public Transf_Unknown_4Yr_By2 transf_unknown_4yr_by { get; set; }
    //    public Transf_Completed_2Yr_By2 transf_completed_2yr_by { get; set; }
    //    public Transf_Completed_4Yr_By2 transf_completed_4yr_by { get; set; }
    //    public Transf_Withdrawn_2Yr_By2 transf_withdrawn_2yr_by { get; set; }
    //    public Transf_Withdrawn_4Yr_By2 transf_withdrawn_4yr_by { get; set; }
    //    public Transf_Still_Enrolled_2Yr_By2 transf_still_enrolled_2yr_by { get; set; }
    //    public Transf_Still_Enrolled_4Yr_By2 transf_still_enrolled_4yr_by { get; set; }
    //}

    //public class Died_By3
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Unknown_By3
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Completed_By3
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Withdrawn_By3
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Still_Enrolled_By2
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Unknown_2Yr_By2
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Unknown_4Yr_By2
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Completed_2Yr_By2
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_4Yr_By2
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_2Yr_By2
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_4Yr_By2
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_2Yr_By2
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_4Yr_By2
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Low_Inc
    //{
    //    public Died_By4 died_by { get; set; }
    //    public Unknown_By4 unknown_by { get; set; }
    //    public Completed_By4 completed_by { get; set; }
    //    public Withdrawn_By4 withdrawn_by { get; set; }
    //    public Still_Enrolled_By3 still_enrolled_by { get; set; }
    //    public Transf_Unknown_2Yr_By3 transf_unknown_2yr_by { get; set; }
    //    public Transf_Unknown_4Yr_By3 transf_unknown_4yr_by { get; set; }
    //    public Transf_Completed_2Yr_By3 transf_completed_2yr_by { get; set; }
    //    public Transf_Completed_4Yr_By3 transf_completed_4yr_by { get; set; }
    //    public Transf_Withdrawn_2Yr_By3 transf_withdrawn_2yr_by { get; set; }
    //    public Transf_Withdrawn_4Yr_By3 transf_withdrawn_4yr_by { get; set; }
    //    public Transf_Still_Enrolled_2Yr_By3 transf_still_enrolled_2yr_by { get; set; }
    //    public Transf_Still_Enrolled_4Yr_By3 transf_still_enrolled_4yr_by { get; set; }
    //}

    //public class Died_By4
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Unknown_By4
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Completed_By4
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Withdrawn_By4
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Still_Enrolled_By3
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Unknown_2Yr_By3
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Unknown_4Yr_By3
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Completed_2Yr_By3
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_4Yr_By3
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_2Yr_By3
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_4Yr_By3
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_2Yr_By3
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_4Yr_By3
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Mid_Inc
    //{
    //    public Died_By5 died_by { get; set; }
    //    public Unknown_By5 unknown_by { get; set; }
    //    public Completed_By5 completed_by { get; set; }
    //    public Withdrawn_By5 withdrawn_by { get; set; }
    //    public Still_Enrolled_By4 still_enrolled_by { get; set; }
    //    public Transf_Unknown_2Yr_By4 transf_unknown_2yr_by { get; set; }
    //    public Transf_Unknown_4Yr_By4 transf_unknown_4yr_by { get; set; }
    //    public Transf_Completed_2Yr_By4 transf_completed_2yr_by { get; set; }
    //    public Transf_Completed_4Yr_By4 transf_completed_4yr_by { get; set; }
    //    public Transf_Withdrawn_2Yr_By4 transf_withdrawn_2yr_by { get; set; }
    //    public Transf_Withdrawn_4Yr_By4 transf_withdrawn_4yr_by { get; set; }
    //    public Transf_Still_Enrolled_2Yr_By4 transf_still_enrolled_2yr_by { get; set; }
    //    public Transf_Still_Enrolled_4Yr_By4 transf_still_enrolled_4yr_by { get; set; }
    //}

    //public class Died_By5
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Unknown_By5
    //{
    //    public float? _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Completed_By5
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Withdrawn_By5
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Still_Enrolled_By4
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Unknown_2Yr_By4
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Unknown_4Yr_By4
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Completed_2Yr_By4
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_4Yr_By4
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_2Yr_By4
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_4Yr_By4
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_2Yr_By4
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_4Yr_By4
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class No_Loan
    //{
    //    public Died_By6 died_by { get; set; }
    //    public Unknown_By6 unknown_by { get; set; }
    //    public Completed_By6 completed_by { get; set; }
    //    public Withdrawn_By6 withdrawn_by { get; set; }
    //    public Still_Enrolled_By5 still_enrolled_by { get; set; }
    //    public Transf_Unknown_2Yr_By5 transf_unknown_2yr_by { get; set; }
    //    public Transf_Unknown_4Yr_By5 transf_unknown_4yr_by { get; set; }
    //    public Transf_Completed_2Yr_By5 transf_completed_2yr_by { get; set; }
    //    public Transf_Completed_4Yr_By5 transf_completed_4yr_by { get; set; }
    //    public Transf_Withdrawn_2Yr_By5 transf_withdrawn_2yr_by { get; set; }
    //    public Transf_Withdrawn_4Yr_By5 transf_withdrawn_4yr_by { get; set; }
    //    public Transf_Still_Enrolled_2Yr_By5 transf_still_enrolled_2yr_by { get; set; }
    //    public Transf_Still_Enrolled_4Yr_By5 transf_still_enrolled_4yr_by { get; set; }
    //}

    //public class Died_By6
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Unknown_By6
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Completed_By6
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Withdrawn_By6
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Still_Enrolled_By5
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Unknown_2Yr_By5
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Unknown_4Yr_By5
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_2Yr_By5
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_4Yr_By5
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_2Yr_By5
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_4Yr_By5
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_2Yr_By5
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_4Yr_By5
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class No_Pell
    //{
    //    public Died_By7 died_by { get; set; }
    //    public Unknown_By7 unknown_by { get; set; }
    //    public Completed_By7 completed_by { get; set; }
    //    public Withdrawn_By7 withdrawn_by { get; set; }
    //    public Still_Enrolled_By6 still_enrolled_by { get; set; }
    //    public Transf_Unknown_2Yr_By6 transf_unknown_2yr_by { get; set; }
    //    public Transf_Unknown_4Yr_By6 transf_unknown_4yr_by { get; set; }
    //    public Transf_Completed_2Yr_By6 transf_completed_2yr_by { get; set; }
    //    public Transf_Completed_4Yr_By6 transf_completed_4yr_by { get; set; }
    //    public Transf_Withdrawn_2Yr_By6 transf_withdrawn_2yr_by { get; set; }
    //    public Transf_Withdrawn_4Yr_By6 transf_withdrawn_4yr_by { get; set; }
    //    public Transf_Still_Enrolled_2Yr_By6 transf_still_enrolled_2yr_by { get; set; }
    //    public Transf_Still_Enrolled_4Yr_By6 transf_still_enrolled_4yr_by { get; set; }
    //}

    //public class Died_By7
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Unknown_By7
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Completed_By7
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Withdrawn_By7
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Still_Enrolled_By6
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Unknown_2Yr_By6
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Unknown_4Yr_By6
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Completed_2Yr_By6
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_4Yr_By6
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_2Yr_By6
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_4Yr_By6
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_2Yr_By6
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_4Yr_By6
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class High_Inc
    //{
    //    public Died_By8 died_by { get; set; }
    //    public Unknown_By8 unknown_by { get; set; }
    //    public Completed_By8 completed_by { get; set; }
    //    public Withdrawn_By8 withdrawn_by { get; set; }
    //    public Still_Enrolled_By7 still_enrolled_by { get; set; }
    //    public Transf_Unknown_2Yr_By7 transf_unknown_2yr_by { get; set; }
    //    public Transf_Unknown_4Yr_By7 transf_unknown_4yr_by { get; set; }
    //    public Transf_Completed_2Yr_By7 transf_completed_2yr_by { get; set; }
    //    public Transf_Completed_4Yr_By7 transf_completed_4yr_by { get; set; }
    //    public Transf_Withdrawn_2Yr_By7 transf_withdrawn_2yr_by { get; set; }
    //    public Transf_Withdrawn_4Yr_By7 transf_withdrawn_4yr_by { get; set; }
    //    public Transf_Still_Enrolled_2Yr_By7 transf_still_enrolled_2yr_by { get; set; }
    //    public Transf_Still_Enrolled_4Yr_By7 transf_still_enrolled_4yr_by { get; set; }
    //}

    //public class Died_By8
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Unknown_By8
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Completed_By8
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Withdrawn_By8
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Still_Enrolled_By7
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Unknown_2Yr_By7
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Unknown_4Yr_By7
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Completed_2Yr_By7
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_4Yr_By7
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_2Yr_By7
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_4Yr_By7
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_2Yr_By7
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_4Yr_By7
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Independ
    //{
    //    public Died_By9 died_by { get; set; }
    //    public Unknown_By9 unknown_by { get; set; }
    //    public Completed_By9 completed_by { get; set; }
    //    public Withdrawn_By9 withdrawn_by { get; set; }
    //    public Still_Enrolled_By8 still_enrolled_by { get; set; }
    //    public Transf_Unknown_2Yr_By8 transf_unknown_2yr_by { get; set; }
    //    public Transf_Unknown_4Yr_By8 transf_unknown_4yr_by { get; set; }
    //    public Transf_Completed_2Yr_By8 transf_completed_2yr_by { get; set; }
    //    public Transf_Completed_4Yr_By8 transf_completed_4yr_by { get; set; }
    //    public Transf_Withdrawn_2Yr_By8 transf_withdrawn_2yr_by { get; set; }
    //    public Transf_Withdrawn_4Yr_By8 transf_withdrawn_4yr_by { get; set; }
    //    public Transf_Still_Enrolled_2Yr_By8 transf_still_enrolled_2yr_by { get; set; }
    //    public Transf_Still_Enrolled_4Yr_By8 transf_still_enrolled_4yr_by { get; set; }
    //}

    //public class Died_By9
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Unknown_By9
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Completed_By9
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Withdrawn_By9
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Still_Enrolled_By8
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Unknown_2Yr_By8
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Unknown_4Yr_By8
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Completed_2Yr_By8
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_4Yr_By8
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_2Yr_By8
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_4Yr_By8
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_2Yr_By8
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_4Yr_By8
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class First_Gen
    //{
    //    public Died_By10 died_by { get; set; }
    //    public Unknown_By10 unknown_by { get; set; }
    //    public Completed_By10 completed_by { get; set; }
    //    public Withdrawn_By10 withdrawn_by { get; set; }
    //    public Still_Enrolled_By9 still_enrolled_by { get; set; }
    //    public Transf_Unknown_2Yr_By9 transf_unknown_2yr_by { get; set; }
    //    public Transf_Unknown_4Yr_By9 transf_unknown_4yr_by { get; set; }
    //    public Transf_Completed_2Yr_By9 transf_completed_2yr_by { get; set; }
    //    public Transf_Completed_4Yr_By9 transf_completed_4yr_by { get; set; }
    //    public Transf_Withdrawn_2Yr_By9 transf_withdrawn_2yr_by { get; set; }
    //    public Transf_Withdrawn_4Yr_By9 transf_withdrawn_4yr_by { get; set; }
    //    public Transf_Still_Enrolled_2Yr_By9 transf_still_enrolled_2yr_by { get; set; }
    //    public Transf_Still_Enrolled_4Yr_By9 transf_still_enrolled_4yr_by { get; set; }
    //}

    //public class Died_By10
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Unknown_By10
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Completed_By10
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Withdrawn_By10
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Still_Enrolled_By9
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Unknown_2Yr_By9
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Unknown_4Yr_By9
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Completed_2Yr_By9
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_4Yr_By9
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_2Yr_By9
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_4Yr_By9
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_2Yr_By9
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_4Yr_By9
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Still_Enrolled_By10
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Loan_Recip
    //{
    //    public Died_By11 died_by { get; set; }
    //    public Unknown_By11 unknown_by { get; set; }
    //    public Completed_By11 completed_by { get; set; }
    //    public Withdrawn_By11 withdrawn_by { get; set; }
    //    public Still_Enrolled_By11 still_enrolled_by { get; set; }
    //    public Transf_Unknown_2Yr_By10 transf_unknown_2yr_by { get; set; }
    //    public Transf_Unknown_4Yr_By10 transf_unknown_4yr_by { get; set; }
    //    public Transf_Completed_2Yr_By10 transf_completed_2yr_by { get; set; }
    //    public Transf_Completed_4Yr_By10 transf_completed_4yr_by { get; set; }
    //    public Transf_Withdrawn_2Yr_By10 transf_withdrawn_2yr_by { get; set; }
    //    public Transf_Withdrawn_4Yr_By10 transf_withdrawn_4yr_by { get; set; }
    //    public Transf_Still_Enrolled_2Yr_By10 transf_still_enrolled_2yr_by { get; set; }
    //    public Transf_Still_Enrolled_4Yr_By10 transf_still_enrolled_4yr_by { get; set; }
    //}

    //public class Died_By11
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Unknown_By11
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Completed_By11
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Withdrawn_By11
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Still_Enrolled_By11
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Unknown_2Yr_By10
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Unknown_4Yr_By10
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_2Yr_By10
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_4Yr_By10
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_2Yr_By10
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_4Yr_By10
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_2Yr_By10
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_4Yr_By10
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Pell_Recip
    //{
    //    public Died_By12 died_by { get; set; }
    //    public Unknown_By12 unknown_by { get; set; }
    //    public Completed_By12 completed_by { get; set; }
    //    public Withdrawn_By12 withdrawn_by { get; set; }
    //    public Still_Enrolled_By12 still_enrolled_by { get; set; }
    //    public Transf_Unknown_2Yr_By11 transf_unknown_2yr_by { get; set; }
    //    public Transf_Unknown_4Yr_By11 transf_unknown_4yr_by { get; set; }
    //    public Transf_Completed_2Yr_By11 transf_completed_2yr_by { get; set; }
    //    public Transf_Completed_4Yr_By11 transf_completed_4yr_by { get; set; }
    //    public Transf_Withdrawn_2Yr_By11 transf_withdrawn_2yr_by { get; set; }
    //    public Transf_Withdrawn_4Yr_By11 transf_withdrawn_4yr_by { get; set; }
    //    public Transf_Still_Enrolled_2Yr_By11 transf_still_enrolled_2yr_by { get; set; }
    //    public Transf_Still_Enrolled_4Yr_By11 transf_still_enrolled_4yr_by { get; set; }
    //}

    //public class Died_By12
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Unknown_By12
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Completed_By12
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Withdrawn_By12
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Still_Enrolled_By12
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Unknown_2Yr_By11
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Unknown_4Yr_By11
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Completed_2Yr_By11
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_4Yr_By11
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_2Yr_By11
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_4Yr_By11
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_2Yr_By11
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_4Yr_By11
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Not_First_Gen
    //{
    //    public Died_By13 died_by { get; set; }
    //    public Unknown_By13 unknown_by { get; set; }
    //    public Completed_By13 completed_by { get; set; }
    //    public Withdrawn_By13 withdrawn_by { get; set; }
    //    public Still_Enrolled_By13 still_enrolled_by { get; set; }
    //    public Transf_Unknown_2Yr_By12 transf_unknown_2yr_by { get; set; }
    //    public Transf_Unknown_4Yr_By12 transf_unknown_4yr_by { get; set; }
    //    public Transf_Completed_2Yr_By12 transf_completed_2yr_by { get; set; }
    //    public Transf_Completed_4Yr_By12 transf_completed_4yr_by { get; set; }
    //    public Transf_Withdrawn_2Yr_By12 transf_withdrawn_2yr_by { get; set; }
    //    public Transf_Withdrawn_4Yr_By12 transf_withdrawn_4yr_by { get; set; }
    //    public Transf_Still_Enrolled_2Yr_By12 transf_still_enrolled_2yr_by { get; set; }
    //    public Transf_Still_Enrolled_4Yr_By12 transf_still_enrolled_4yr_by { get; set; }
    //}

    //public class Died_By13
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Unknown_By13
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Completed_By13
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Withdrawn_By13
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Still_Enrolled_By13
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Unknown_2Yr_By12
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Unknown_4Yr_By12
    //{
    //    public object _2yrs { get; set; }
    //    public object _3yrs { get; set; }
    //    public object _4yrs { get; set; }
    //    public object _6yrs { get; set; }
    //    public object _8yrs { get; set; }
    //}

    //public class Transf_Completed_2Yr_By12
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_4Yr_By12
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_2Yr_By12
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_4Yr_By12
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_2Yr_By12
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_4Yr_By12
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Unknown_2Yr_By13
    //{
    //    public object _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Unknown_4Yr_By13
    //{
    //    public object _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_2Yr_By13
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Completed_4Yr_By13
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_2Yr_By13
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Withdrawn_4Yr_By13
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_2Yr_By13
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Transf_Still_Enrolled_4Yr_By13
    //{
    //    public float? _2yrs { get; set; }
    //    public float? _3yrs { get; set; }
    //    public float? _4yrs { get; set; }
    //    public float? _6yrs { get; set; }
    //    public float? _8yrs { get; set; }
    //}

    //public class Separation_Date
    //{
    //    public string median { get; set; }
    //    public int? number { get; set; }
    //}

    //public class _2_Yr_Completion
    //{
    //    public int overall { get; set; }
    //    public int low_income { get; set; }
    //    public int? pell_grant { get; set; }
    //    public int? high_income { get; set; }
    //    public int? loan_students { get; set; }
    //    public int? male_students { get; set; }
    //    public int? middle_income { get; set; }
    //    public int? no_pell_grant { get; set; }
    //    public int? female_students { get; set; }
    //    public int? no_loan_students { get; set; }
    //    public int? dependent_students { get; set; }
    //    public int? independent_students { get; set; }
    //    public int? first_generation_students { get; set; }
    //    public int? no_first_generation_students { get; set; }
    //}

    //public class _3_Yr_Completion
    //{
    //    public int overall { get; set; }
    //    public int low_income { get; set; }
    //    public int? pell_grant { get; set; }
    //    public int? high_income { get; set; }
    //    public int? loan_students { get; set; }
    //    public int? male_students { get; set; }
    //    public int? middle_income { get; set; }
    //    public int? no_pell_grant { get; set; }
    //    public int? female_students { get; set; }
    //    public int? no_loan_students { get; set; }
    //    public int dependent_students { get; set; }
    //    public int independent_students { get; set; }
    //    public int? first_generation_students { get; set; }
    //    public int? no_first_generation_students { get; set; }
    //}

    //public class _4_Yr_Completion
    //{
    //    public int overall { get; set; }
    //    public int low_income { get; set; }
    //    public int? pell_grant { get; set; }
    //    public int? high_income { get; set; }
    //    public int? loan_students { get; set; }
    //    public int? male_students { get; set; }
    //    public int? middle_income { get; set; }
    //    public int? no_pell_grant { get; set; }
    //    public int? female_students { get; set; }
    //    public int? no_loan_students { get; set; }
    //    public int? dependent_students { get; set; }
    //    public int? independent_students { get; set; }
    //    public int? first_generation_students { get; set; }
    //    public int? no_first_generation_students { get; set; }
    //}

    //public class _6_Yr_Completion
    //{
    //    public int overall { get; set; }
    //    public int low_income { get; set; }
    //    public int? pell_grant { get; set; }
    //    public int? high_income { get; set; }
    //    public int? loan_students { get; set; }
    //    public int? male_students { get; set; }
    //    public int? middle_income { get; set; }
    //    public int? no_pell_grant { get; set; }
    //    public int? female_students { get; set; }
    //    public int? no_loan_students { get; set; }
    //    public int dependent_students { get; set; }
    //    public int independent_students { get; set; }
    //    public int? first_generation_students { get; set; }
    //    public int? no_first_generation_students { get; set; }
    //}

    //public class _8_Yr_Completion
    //{
    //    public int overall { get; set; }
    //    public int? low_income { get; set; }
    //    public int? pell_grant { get; set; }
    //    public int? high_income { get; set; }
    //    public int? loan_students { get; set; }
    //    public int? male_students { get; set; }
    //    public int? middle_income { get; set; }
    //    public int? no_pell_grant { get; set; }
    //    public int? female_students { get; set; }
    //    public int? no_loan_students { get; set; }
    //    public int? dependent_students { get; set; }
    //    public int? independent_students { get; set; }
    //    public int? first_generation_students { get; set; }
    //    public int? no_first_generation_students { get; set; }
    //}

    //public class Rate_Suppressed
    //{
    //    public float? overall { get; set; }
    //    public float? four_year { get; set; }
    //    public float? lt_four_year { get; set; }
    //    public float? four_year_100_pooled { get; set; }
    //    public float? four_year_200percent { get; set; }
    //    public Consumer3 consumer { get; set; }
    //    public float? lt_four_year_100_pooled { get; set; }
    //    public float? lt_four_year_150percent { get; set; }
    //}

    //public class Consumer3
    //{
    //    public float overall_median { get; set; }
    //    public float median_by_pred_degree { get; set; }
    //}

    //public class Outcome_Years
    //{
    //    public int? om_full_time { get; set; }
    //    public int? om_part_time { get; set; }
    //    public int? om_first_time { get; set; }
    //    public int? om_all_students { get; set; }
    //    public int? om_not_first_time { get; set; }
    //    public Full_Time full_time { get; set; }
    //    public Part_Time part_time { get; set; }
    //}

    //public class Full_Time
    //{
    //    public int? first_time { get; set; }
    //    public int? not_first_time { get; set; }
    //}

    //public class Part_Time
    //{
    //    public int? first_time { get; set; }
    //    public int? not_first_time { get; set; }
    //}

    //public class Transfer_Rate
    //{
    //    public _4Yr _4yr { get; set; }
    //    public Cohort_4Yr cohort_4yr { get; set; }
    //    public Less_Than_4Yr less_than_4yr { get; set; }
    //    public Cohort_Less_Than_4Yr cohort_less_than_4yr { get; set; }
    //}

    //public class _4Yr
    //{
    //    public float? full_time { get; set; }
    //    public float? full_time_pooled { get; set; }
    //}

    //public class Cohort_4Yr
    //{
    //    public int? full_time { get; set; }
    //    public int? full_time_pooled { get; set; }
    //}

    //public class Less_Than_4Yr
    //{
    //    public float? full_time { get; set; }
    //    public float? full_time_pooled { get; set; }
    //}

    //public class Cohort_Less_Than_4Yr
    //{
    //    public int? full_time { get; set; }
    //    public int? full_time_pooled { get; set; }
    //}

    //public class Outcome_Years_Pell
    //{
    //    public int? om_full_time { get; set; }
    //    public int? om_part_time { get; set; }
    //    public int? om_first_time { get; set; }
    //    public int? om_all_students { get; set; }
    //    public int? om_not_first_time { get; set; }
    //    public Full_Time1 full_time { get; set; }
    //    public Part_Time1 part_time { get; set; }
    //}

    //public class Full_Time1
    //{
    //    public int? first_time { get; set; }
    //    public int? not_first_time { get; set; }
    //}

    //public class Part_Time1
    //{
    //    public int? first_time { get; set; }
    //    public int? not_first_time { get; set; }
    //}

    //public class Completion_Rate_4Yr_150_Race
    //{
    //    public float? unknown { get; set; }
    //}

    //public class Completion_Rate_L4yr_150_Race
    //{
    //    public float? unknown { get; set; }
    //}

    //public class Completion_Cohort_4Yr_150_Race
    //{
    //    public int? unknown { get; set; }
    //}

    //public class Outcome_Percentage
    //{
    //    public Full_Time2 full_time { get; set; }
    //    public Part_Time2 part_time { get; set; }
    //    public First_Time2 first_time { get; set; }
    //    public All_Students all_students { get; set; }
    //    public Not_First_Time2 not_first_time { get; set; }
    //}

    //public class Full_Time2
    //{
    //    public _8Yr _8yr { get; set; }
    //    public First_Time first_time { get; set; }
    //    public Not_First_Time not_first_time { get; set; }
    //}

    //public class _8Yr
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? still_enrolled { get; set; }
    //}

    //public class First_Time
    //{
    //    public _6Yr _6yr { get; set; }
    //    public _8Yr1 _8yr { get; set; }
    //}

    //public class _6Yr
    //{
    //    public float? award { get; set; }
    //    public float? award_pooled { get; set; }
    //}

    //public class _8Yr1
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? award_pooled { get; set; }
    //    public float? still_enrolled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Not_First_Time
    //{
    //    public _6Yr1 _6yr { get; set; }
    //    public _8Yr2 _8yr { get; set; }
    //}

    //public class _6Yr1
    //{
    //    public float? award { get; set; }
    //    public float? award_pooled { get; set; }
    //}

    //public class _8Yr2
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? award_pooled { get; set; }
    //    public float? still_enrolled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Part_Time2
    //{
    //    public _8Yr3 _8yr { get; set; }
    //    public First_Time1 first_time { get; set; }
    //    public Not_First_Time1 not_first_time { get; set; }
    //}

    //public class _8Yr3
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? still_enrolled { get; set; }
    //}

    //public class First_Time1
    //{
    //    public _6Yr2 _6yr { get; set; }
    //    public _8Yr4 _8yr { get; set; }
    //}

    //public class _6Yr2
    //{
    //    public float? award { get; set; }
    //    public float? award_pooled { get; set; }
    //}

    //public class _8Yr4
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? award_pooled { get; set; }
    //    public float? still_enrolled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Not_First_Time1
    //{
    //    public _6Yr3 _6yr { get; set; }
    //    public _8Yr5 _8yr { get; set; }
    //}

    //public class _6Yr3
    //{
    //    public float? award { get; set; }
    //    public float? award_pooled { get; set; }
    //}

    //public class _8Yr5
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? award_pooled { get; set; }
    //    public float? still_enrolled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class First_Time2
    //{
    //    public _8Yr6 _8yr { get; set; }
    //}

    //public class _8Yr6
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? still_enrolled { get; set; }
    //}

    //public class All_Students
    //{
    //    public _8Yr7 _8yr { get; set; }
    //}

    //public class _8Yr7
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? still_enrolled { get; set; }
    //}

    //public class Not_First_Time2
    //{
    //    public _8Yr8 _8yr { get; set; }
    //}

    //public class _8Yr8
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? still_enrolled { get; set; }
    //}

    //public class Outcome_Cohort
    //{
    //    public Full_Time3 full_time { get; set; }
    //    public Part_Time3 part_time { get; set; }
    //}

    //public class Full_Time3
    //{
    //    public First_Time3 first_time { get; set; }
    //    public Not_First_Time3 not_first_time { get; set; }
    //}

    //public class First_Time3
    //{
    //    public int? _6yr { get; set; }
    //    public int? _8yr { get; set; }
    //    public int? _6yr_pooled { get; set; }
    //    public int? _8yr_pooled { get; set; }
    //}

    //public class Not_First_Time3
    //{
    //    public int? _6yr { get; set; }
    //    public int? _8yr { get; set; }
    //    public int? _6yr_pooled { get; set; }
    //    public int? _8yr_pooled { get; set; }
    //}

    //public class Part_Time3
    //{
    //    public First_Time4 first_time { get; set; }
    //    public Not_First_Time4 not_first_time { get; set; }
    //}

    //public class First_Time4
    //{
    //    public int? _6yr { get; set; }
    //    public int? _8yr { get; set; }
    //    public int? _6yr_pooled { get; set; }
    //    public int? _8yr_pooled { get; set; }
    //}

    //public class Not_First_Time4
    //{
    //    public int? _6yr { get; set; }
    //    public int? _8yr { get; set; }
    //    public int? _6yr_pooled { get; set; }
    //    public int? _8yr_pooled { get; set; }
    //}

    //public class Completion_Rate_4Yr_150_Nonresident
    //{
    //    public float? alien { get; set; }
    //}

    //public class Rate_Suppressed_Pell
    //{
    //    public float? four_year_150_pooled { get; set; }
    //    public float? lt_four_year_150_pooled { get; set; }
    //}

    //public class Completion_Rate_L4yr_150_Nonresident
    //{
    //    public float? alien { get; set; }
    //}

    //public class Completion_Cohort_4Yr_150_Nonresident
    //{
    //    public int? alien { get; set; }
    //}

    //public class Outcome_Percentage_Pell
    //{
    //    public Full_Time4 full_time { get; set; }
    //    public Part_Time4 part_time { get; set; }
    //    public First_Time7 first_time { get; set; }
    //    public All_Students1 all_students { get; set; }
    //    public Not_First_Time7 not_first_time { get; set; }
    //}

    //public class Full_Time4
    //{
    //    public _8Yr9 _8yr { get; set; }
    //    public First_Time5 first_time { get; set; }
    //    public Not_First_Time5 not_first_time { get; set; }
    //}

    //public class _8Yr9
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? award_pooled { get; set; }
    //    public float? still_enrolled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class First_Time5
    //{
    //    public _8Yr10 _8yr { get; set; }
    //}

    //public class _8Yr10
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? award_pooled { get; set; }
    //    public float? still_enrolled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Not_First_Time5
    //{
    //    public _8Yr11 _8yr { get; set; }
    //}

    //public class _8Yr11
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? award_pooled { get; set; }
    //    public float? still_enrolled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Part_Time4
    //{
    //    public _8Yr12 _8yr { get; set; }
    //    public First_Time6 first_time { get; set; }
    //    public Not_First_Time6 not_first_time { get; set; }
    //}

    //public class _8Yr12
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? award_pooled { get; set; }
    //    public float? still_enrolled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class First_Time6
    //{
    //    public _8Yr13 _8yr { get; set; }
    //}

    //public class _8Yr13
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? award_pooled { get; set; }
    //    public float? still_enrolled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Not_First_Time6
    //{
    //    public _8Yr14 _8yr { get; set; }
    //}

    //public class _8Yr14
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? award_pooled { get; set; }
    //    public float? still_enrolled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class First_Time7
    //{
    //    public _8Yr15 _8yr { get; set; }
    //}

    //public class _8Yr15
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? award_pooled { get; set; }
    //    public float? still_enrolled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class All_Students1
    //{
    //    public _8Yr16 _8yr { get; set; }
    //}

    //public class _8Yr16
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? award_pooled { get; set; }
    //    public float? still_enrolled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Not_First_Time7
    //{
    //    public _8Yr17 _8yr { get; set; }
    //}

    //public class _8Yr17
    //{
    //    public float? award { get; set; }
    //    public float? unknown { get; set; }
    //    public float? transfer { get; set; }
    //    public float? award_pooled { get; set; }
    //    public float? still_enrolled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Outcome_Cohort_Pell
    //{
    //    public Full_Time5 full_time { get; set; }
    //    public Part_Time5 part_time { get; set; }
    //}

    //public class Full_Time5
    //{
    //    public First_Time8 first_time { get; set; }
    //    public Not_First_Time8 not_first_time { get; set; }
    //}

    //public class First_Time8
    //{
    //    public int? _8yr { get; set; }
    //    public int? _8yr_pooled { get; set; }
    //}

    //public class Not_First_Time8
    //{
    //    public int? _8yr { get; set; }
    //    public int? _8yr_pooled { get; set; }
    //}

    //public class Part_Time5
    //{
    //    public First_Time9 first_time { get; set; }
    //    public Not_First_Time9 not_first_time { get; set; }
    //}

    //public class First_Time9
    //{
    //    public int? _8yr { get; set; }
    //    public int? _8yr_pooled { get; set; }
    //}

    //public class Not_First_Time9
    //{
    //    public int? _8yr { get; set; }
    //    public int? _8yr_pooled { get; set; }
    //}

    //public class Transfer_Rate_Suppressed
    //{
    //    public _4Yr1 _4yr { get; set; }
    //    public Less_Than_4Yr1 less_than_4yr { get; set; }
    //}

    //public class _4Yr1
    //{
    //    public float? full_time_pooled { get; set; }
    //}

    //public class Less_Than_4Yr1
    //{
    //    public float? full_time_pooled { get; set; }
    //}

    //public class Completion_Cohort_Less_Than_4Yr_150_Race
    //{
    //    public int? unknown { get; set; }
    //}

    //public class Completion_Cohort_Less_Than_4Yr_150_Nonresident
    //{
    //    public int? alien { get; set; }
    //}

    //public class Outcome_Percentage_Suppressed
    //{
    //    public Full_Time6 full_time { get; set; }
    //    public Part_Time6 part_time { get; set; }
    //    public First_Time12 first_time { get; set; }
    //    public All_Students2 all_students { get; set; }
    //    public Not_First_Time12 not_first_time { get; set; }
    //}

    //public class Full_Time6
    //{
    //    public _8Yr18 _8yr { get; set; }
    //    public First_Time10 first_time { get; set; }
    //    public Not_First_Time10 not_first_time { get; set; }
    //}

    //public class _8Yr18
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class First_Time10
    //{
    //    public _6Yr4 _6yr { get; set; }
    //    public _8Yr19 _8yr { get; set; }
    //}

    //public class _6Yr4
    //{
    //    public float? award_pooled { get; set; }
    //}

    //public class _8Yr19
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Not_First_Time10
    //{
    //    public _6Yr5 _6yr { get; set; }
    //    public _8Yr20 _8yr { get; set; }
    //}

    //public class _6Yr5
    //{
    //    public float? award_pooled { get; set; }
    //}

    //public class _8Yr20
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Part_Time6
    //{
    //    public _8Yr21 _8yr { get; set; }
    //    public First_Time11 first_time { get; set; }
    //    public Not_First_Time11 not_first_time { get; set; }
    //}

    //public class _8Yr21
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class First_Time11
    //{
    //    public _6Yr6 _6yr { get; set; }
    //    public _8Yr22 _8yr { get; set; }
    //}

    //public class _6Yr6
    //{
    //    public float? award_pooled { get; set; }
    //}

    //public class _8Yr22
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Not_First_Time11
    //{
    //    public _6Yr7 _6yr { get; set; }
    //    public _8Yr23 _8yr { get; set; }
    //}

    //public class _6Yr7
    //{
    //    public float? award_pooled { get; set; }
    //}

    //public class _8Yr23
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class First_Time12
    //{
    //    public _8Yr24 _8yr { get; set; }
    //}

    //public class _8Yr24
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class All_Students2
    //{
    //    public _8Yr25 _8yr { get; set; }
    //}

    //public class _8Yr25
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Not_First_Time12
    //{
    //    public _8Yr26 _8yr { get; set; }
    //}

    //public class _8Yr26
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Outcome_Percentage_Pell_Suppressed
    //{
    //    public Full_Time7 full_time { get; set; }
    //    public Part_Time7 part_time { get; set; }
    //    public First_Time15 first_time { get; set; }
    //    public All_Students3 all_students { get; set; }
    //    public Not_First_Time15 not_first_time { get; set; }
    //}

    //public class Full_Time7
    //{
    //    public _8Yr27 _8yr { get; set; }
    //    public First_Time13 first_time { get; set; }
    //    public Not_First_Time13 not_first_time { get; set; }
    //}

    //public class _8Yr27
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class First_Time13
    //{
    //    public _8Yr28 _8yr { get; set; }
    //}

    //public class _8Yr28
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Not_First_Time13
    //{
    //    public _8Yr29 _8yr { get; set; }
    //}

    //public class _8Yr29
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Part_Time7
    //{
    //    public _8Yr30 _8yr { get; set; }
    //    public First_Time14 first_time { get; set; }
    //    public Not_First_Time14 not_first_time { get; set; }
    //}

    //public class _8Yr30
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class First_Time14
    //{
    //    public _8Yr31 _8yr { get; set; }
    //}

    //public class _8Yr31
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Not_First_Time14
    //{
    //    public _8Yr32 _8yr { get; set; }
    //}

    //public class _8Yr32
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class First_Time15
    //{
    //    public _8Yr33 _8yr { get; set; }
    //}

    //public class _8Yr33
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class All_Students3
    //{
    //    public _8Yr34 _8yr { get; set; }
    //}

    //public class _8Yr34
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Not_First_Time15
    //{
    //    public _8Yr35 _8yr { get; set; }
    //}

    //public class _8Yr35
    //{
    //    public float? award_pooled { get; set; }
    //    public float? unknown_pooled { get; set; }
    //    public float? transfer_pooled { get; set; }
    //    public float? still_enrolled_pooled { get; set; }
    //}

    //public class Repayment
    //{
    //    public float? _2_yr_default_rate { get; set; }
    //    public float? _3_yr_default_rate { get; set; }
    //    public Repayment_Date repayment_date { get; set; }
    //    public _1_Yr_Repayment _1_yr_repayment { get; set; }
    //    public _3_Yr_Repayment _3_yr_repayment { get; set; }
    //    public _5_Yr_Repayment _5_yr_repayment { get; set; }
    //    public _7_Yr_Repayment _7_yr_repayment { get; set; }
    //    public int? _2_yr_default_rate_denom { get; set; }
    //    public int? _3_yr_default_rate_denom { get; set; }
    //    public _1_Yr_Db_Pp_Repayment _1_yr_db_pp_repayment { get; set; }
    //    public _4_Yr_Db_Pp_Repayment _4_yr_db_pp_repayment { get; set; }
    //    public _5_Yr_Db_Pp_Repayment _5_yr_db_pp_repayment { get; set; }
    //    public _10_Yr_Db_Pp_Repayment _10_yr_db_pp_repayment { get; set; }
    //    public _1_Yr_Bb_Pp_Repayment _1_yr_bb_pp_repayment { get; set; }
    //    public _1_Yr_Db_Fed_Repayment _1_yr_db_fed_repayment { get; set; }
    //    public _20_Yr_Db_Pp_Repayment _20_yr_db_pp_repayment { get; set; }
    //    public _2_Yr_Bb_Pp_Repayment _2_yr_bb_pp_repayment { get; set; }
    //    public _3_Yr_Bb_Pp_Repayment _3_yr_bb_pp_repayment { get; set; }
    //    public _4_Yr_Db_Fed_Repayment _4_yr_db_fed_repayment { get; set; }
    //    public _5_Yr_Db_Fed_Repayment _5_yr_db_fed_repayment { get; set; }
    //    public _10_Yr_Db_Fed_Repayment _10_yr_db_fed_repayment { get; set; }
    //    public _1_Yr_Bb_Fed_Repayment _1_yr_bb_fed_repayment { get; set; }
    //    public _20_Yr_Db_Fed_Repayment _20_yr_db_fed_repayment { get; set; }
    //    public _2_Yr_Bb_Fed_Repayment _2_yr_bb_fed_repayment { get; set; }
    //    public _3_Yr_Bb_Fed_Repayment _3_yr_bb_fed_repayment { get; set; }
    //    public _3_Yr_Repayment_Suppressed _3_yr_repayment_suppressed { get; set; }
    //    public _2_Yr_Bb_Fed_Repayment_Suppressed _2_yr_bb_fed_repayment_suppressed { get; set; }
    //    public Repayment_Cohort repayment_cohort { get; set; }
    //}

    //public class Repayment_Date
    //{
    //    public string median { get; set; }
    //    public int? number { get; set; }
    //}

    //public class _1_Yr_Repayment
    //{
    //    public int? overall { get; set; }
    //    public int? completers { get; set; }
    //    public int? low_income { get; set; }
    //    public int? pell_grant { get; set; }
    //    public int? high_income { get; set; }
    //    public int? male_students { get; set; }
    //    public int? middle_income { get; set; }
    //    public int? no_pell_grant { get; set; }
    //    public int? noncompleters { get; set; }
    //    public Income4 income { get; set; }
    //    public float? completers_rate { get; set; }
    //    public int? female_students { get; set; }
    //    public float? pell_grant_rate { get; set; }
    //    public int? dependent_students { get; set; }
    //    public float? male_students_rate { get; set; }
    //    public float? no_pell_grant_rate { get; set; }
    //    public float? noncompleters_rate { get; set; }
    //    public float? female_students_rate { get; set; }
    //    public int? independent_students { get; set; }
    //    public float? dependent_students_rate { get; set; }
    //    public int? first_generation_students { get; set; }
    //    public float? independent_students_rate { get; set; }
    //    public int? non_first_generation_students { get; set; }
    //    public float? first_generation_students_rate { get; set; }
    //    public float? non_first_generation_students_rate { get; set; }
    //}

    //public class Income4
    //{
    //    public float? _0_30000 { get; set; }
    //    public float? _30000_75000 { get; set; }
    //    public float? greater_than_75000 { get; set; }
    //}

    //public class _3_Yr_Repayment
    //{
    //    public int? overall { get; set; }
    //    public int? completers { get; set; }
    //    public int? low_income { get; set; }
    //    public int? pell_grant { get; set; }
    //    public int? high_income { get; set; }
    //    public int? male_students { get; set; }
    //    public int? middle_income { get; set; }
    //    public int? no_pell_grant { get; set; }
    //    public int? noncompleters { get; set; }
    //    public Income5 income { get; set; }
    //    public float? completers_rate { get; set; }
    //    public int? female_students { get; set; }
    //    public float? pell_grant_rate { get; set; }
    //    public int? dependent_students { get; set; }
    //    public float? male_students_rate { get; set; }
    //    public float? no_pell_grant_rate { get; set; }
    //    public float? noncompleters_rate { get; set; }
    //    public float? female_students_rate { get; set; }
    //    public int? independent_students { get; set; }
    //    public float? dependent_students_rate { get; set; }
    //    public int? first_generation_students { get; set; }
    //    public float? independent_students_rate { get; set; }
    //    public int? non_first_generation_students { get; set; }
    //    public float? first_generation_students_rate { get; set; }
    //    public float? non_first_generation_students_rate { get; set; }
    //}

    //public class Income5
    //{
    //    public float? _0_30000 { get; set; }
    //    public float? _30000_75000 { get; set; }
    //    public float? greater_than_75000 { get; set; }
    //}

    //public class _5_Yr_Repayment
    //{
    //    public int? overall { get; set; }
    //    public int? completers { get; set; }
    //    public int? low_income { get; set; }
    //    public int? pell_grant { get; set; }
    //    public int? high_income { get; set; }
    //    public int? male_students { get; set; }
    //    public int? middle_income { get; set; }
    //    public int? no_pell_grant { get; set; }
    //    public int? noncompleters { get; set; }
    //    public Income6 income { get; set; }
    //    public float? completers_rate { get; set; }
    //    public int? female_students { get; set; }
    //    public float? pell_grant_rate { get; set; }
    //    public int? dependent_students { get; set; }
    //    public float? male_students_rate { get; set; }
    //    public float? no_pell_grant_rate { get; set; }
    //    public float? noncompleters_rate { get; set; }
    //    public float? female_students_rate { get; set; }
    //    public int? independent_students { get; set; }
    //    public float? dependent_students_rate { get; set; }
    //    public int? first_generation_students { get; set; }
    //    public float? independent_students_rate { get; set; }
    //    public int? non_first_generation_students { get; set; }
    //    public float? first_generation_students_rate { get; set; }
    //    public float? non_first_generation_students_rate { get; set; }
    //}

    //public class Income6
    //{
    //    public float? _0_30000 { get; set; }
    //    public float? _30000_75000 { get; set; }
    //    public float? greater_than_75000 { get; set; }
    //}

    //public class _7_Yr_Repayment
    //{
    //    public int? overall { get; set; }
    //    public int? completers { get; set; }
    //    public int? low_income { get; set; }
    //    public int? pell_grant { get; set; }
    //    public int? high_income { get; set; }
    //    public int? male_students { get; set; }
    //    public int? middle_income { get; set; }
    //    public int? no_pell_grant { get; set; }
    //    public int? noncompleters { get; set; }
    //    public Income7 income { get; set; }
    //    public float? completers_rate { get; set; }
    //    public int? female_students { get; set; }
    //    public float? pell_grant_rate { get; set; }
    //    public int? dependent_students { get; set; }
    //    public float? male_students_rate { get; set; }
    //    public float? no_pell_grant_rate { get; set; }
    //    public float? noncompleters_rate { get; set; }
    //    public float? female_students_rate { get; set; }
    //    public int? independent_students { get; set; }
    //    public float? dependent_students_rate { get; set; }
    //    public int? first_generation_students { get; set; }
    //    public float? independent_students_rate { get; set; }
    //    public int? non_first_generation_students { get; set; }
    //    public float? first_generation_students_rate { get; set; }
    //    public float? non_first_generation_students_rate { get; set; }
    //}

    //public class Income7
    //{
    //    public float? _0_30000 { get; set; }
    //    public float? _30000_75000 { get; set; }
    //    public float? greater_than_75000 { get; set; }
    //}

    //public class _1_Yr_Db_Pp_Repayment
    //{
    //    public Ug ug { get; set; }
    //    public Ug_Completer ug_completer { get; set; }
    //    public Ug_Noncompleter ug_noncompleter { get; set; }
    //    public Ug_Completer_Unknown ug_completer_unknown { get; set; }
    //}

    //public class Ug
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug_Completer
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug_Noncompleter
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug_Completer_Unknown
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class _4_Yr_Db_Pp_Repayment
    //{
    //    public Ug1 ug { get; set; }
    //    public Ug_Completer1 ug_completer { get; set; }
    //    public Ug_Noncompleter1 ug_noncompleter { get; set; }
    //    public Ug_Completer_Unknown1 ug_completer_unknown { get; set; }
    //}

    //public class Ug1
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug_Completer1
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug_Noncompleter1
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug_Completer_Unknown1
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class _5_Yr_Db_Pp_Repayment
    //{
    //    public Ug2 ug { get; set; }
    //}

    //public class Ug2
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class _10_Yr_Db_Pp_Repayment
    //{
    //    public Ug3 ug { get; set; }
    //}

    //public class Ug3
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class _1_Yr_Bb_Pp_Repayment
    //{
    //    public Ug4 ug { get; set; }
    //    public Male2 male { get; set; }
    //    public Pell1 pell { get; set; }
    //    public Ugcomp ugcomp { get; set; }
    //    public Non_Male non_male { get; set; }
    //    public Non_Pell non_pell { get; set; }
    //    public Ugnocomp ugnocomp { get; set; }
    //    public Dependent dependent { get; set; }
    //    public Ugunkcomp ugunkcomp { get; set; }
    //    public Independent independent { get; set; }
    //}

    //public class Ug4
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Male2
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Pell1
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Ugcomp
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public float? noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Non_Male
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Non_Pell
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Ugnocomp
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public float? deferment { get; set; }
    //    public object discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Dependent
    //{
    //    public object count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public object forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Ugunkcomp
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public float? deferment { get; set; }
    //    public string discharge { get; set; }
    //    public float? fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public float? noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public float? makingprogress { get; set; }
    //}

    //public class Independent
    //{
    //    public object count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public object forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class _1_Yr_Db_Fed_Repayment
    //{
    //    public Gr gr { get; set; }
    //    public Ug5 ug { get; set; }
    //    public Gr_Completer gr_completer { get; set; }
    //    public Ug_Completer2 ug_completer { get; set; }
    //    public Gr_Noncompleter gr_noncompleter { get; set; }
    //    public Ug_Noncompleter2 ug_noncompleter { get; set; }
    //    public Ug_Completer_Unknown2 ug_completer_unknown { get; set; }
    //}

    //public class Gr
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug5
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Gr_Completer
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug_Completer2
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Gr_Noncompleter
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug_Noncompleter2
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug_Completer_Unknown2
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class _20_Yr_Db_Pp_Repayment
    //{
    //    public Ug6 ug { get; set; }
    //}

    //public class Ug6
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class _2_Yr_Bb_Pp_Repayment
    //{
    //    public Ug7 ug { get; set; }
    //    public Male3 male { get; set; }
    //    public Pell2 pell { get; set; }
    //    public Ugcomp1 ugcomp { get; set; }
    //    public Non_Male1 non_male { get; set; }
    //    public Non_Pell1 non_pell { get; set; }
    //    public Ugnocomp1 ugnocomp { get; set; }
    //    public Dependent1 dependent { get; set; }
    //    public Ugunkcomp1 ugunkcomp { get; set; }
    //    public Independent1 independent { get; set; }
    //}

    //public class Ug7
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Male3
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Pell2
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Ugcomp1
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public object forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Non_Male1
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Non_Pell1
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Ugnocomp1
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Dependent1
    //{
    //    public object count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public object forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Ugunkcomp1
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public object forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Independent1
    //{
    //    public object count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public object forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class _3_Yr_Bb_Pp_Repayment
    //{
    //    public Ug8 ug { get; set; }
    //    public Male4 male { get; set; }
    //    public Pell3 pell { get; set; }
    //    public Ugcomp2 ugcomp { get; set; }
    //    public Non_Male2 non_male { get; set; }
    //    public Non_Pell2 non_pell { get; set; }
    //    public Dependent2 dependent { get; set; }
    //    public Ugnoncomp ugnoncomp { get; set; }
    //    public Ugunkcomp2 ugunkcomp { get; set; }
    //    public Independent2 independent { get; set; }
    //}

    //public class Ug8
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Male4
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Pell3
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Ugcomp2
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Non_Male2
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Non_Pell2
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Dependent2
    //{
    //    public object count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public object forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Ugnoncomp
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Ugunkcomp2
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Independent2
    //{
    //    public object count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public object forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class _4_Yr_Db_Fed_Repayment
    //{
    //    public Gr1 gr { get; set; }
    //    public Ug9 ug { get; set; }
    //    public Ug_Completer3 ug_completer { get; set; }
    //    public Ug_Noncompleter3 ug_noncompleter { get; set; }
    //    public Ug_Completer_Unknown3 ug_completer_unknown { get; set; }
    //}

    //public class Gr1
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug9
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug_Completer3
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug_Noncompleter3
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug_Completer_Unknown3
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class _5_Yr_Db_Fed_Repayment
    //{
    //    public Gr2 gr { get; set; }
    //    public Ug10 ug { get; set; }
    //}

    //public class Gr2
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug10
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class _10_Yr_Db_Fed_Repayment
    //{
    //    public Gr3 gr { get; set; }
    //    public Ug11 ug { get; set; }
    //}

    //public class Gr3
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug11
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class _1_Yr_Bb_Fed_Repayment
    //{
    //    public Gr4 gr { get; set; }
    //    public Ug12 ug { get; set; }
    //    public Male5 male { get; set; }
    //    public Pell4 pell { get; set; }
    //    public Grcomp grcomp { get; set; }
    //    public Ugcomp3 ugcomp { get; set; }
    //    public Grnocomp grnocomp { get; set; }
    //    public Non_Male3 non_male { get; set; }
    //    public Non_Pell3 non_pell { get; set; }
    //    public Ugnocomp2 ugnocomp { get; set; }
    //    public Dependent3 dependent { get; set; }
    //    public Ugunkcomp3 ugunkcomp { get; set; }
    //    public Independent3 independent { get; set; }
    //}

    //public class Gr4
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public float? noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Ug12
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public float? noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Male5
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Pell4
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Grcomp
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public float? noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Ugcomp3
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Grnocomp
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public object deferment { get; set; }
    //    public string discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public float? noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Non_Male3
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Non_Pell3
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Ugnocomp2
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Dependent3
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Ugunkcomp3
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public object deferment { get; set; }
    //    public string discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public float? noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Independent3
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class _20_Yr_Db_Fed_Repayment
    //{
    //    public Gr5 gr { get; set; }
    //    public Ug13 ug { get; set; }
    //}

    //public class Gr5
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class Ug13
    //{
    //    public float? rate { get; set; }
    //    public int? count { get; set; }
    //    public int? numerator { get; set; }
    //    public int? denominator { get; set; }
    //}

    //public class _2_Yr_Bb_Fed_Repayment
    //{
    //    public Gr6 gr { get; set; }
    //    public Ug14 ug { get; set; }
    //    public Male6 male { get; set; }
    //    public Pell5 pell { get; set; }
    //    public Grcomp1 grcomp { get; set; }
    //    public Ugcomp4 ugcomp { get; set; }
    //    public Grnocomp1 grnocomp { get; set; }
    //    public Non_Male4 non_male { get; set; }
    //    public Non_Pell4 non_pell { get; set; }
    //    public Ugnocomp3 ugnocomp { get; set; }
    //    public Dependent4 dependent { get; set; }
    //    public Ugunkcomp4 ugunkcomp { get; set; }
    //    public Independent4 independent { get; set; }
    //}

    //public class Gr6
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public float? deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public float? noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Ug14
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Male6
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Pell5
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Grcomp1
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public float? noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Ugcomp4
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Grnocomp1
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public string discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public float? noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Non_Male4
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Non_Pell4
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Ugnocomp3
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public string discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public float? noprogress { get; set; }
    //    public object forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Dependent4
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Ugunkcomp4
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public string discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public float? noprogress { get; set; }
    //    public object forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Independent4
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class _3_Yr_Bb_Fed_Repayment
    //{
    //    public Gr7 gr { get; set; }
    //    public Ug15 ug { get; set; }
    //    public Male7 male { get; set; }
    //    public Pell6 pell { get; set; }
    //    public Grcomp2 grcomp { get; set; }
    //    public Ugcomp5 ugcomp { get; set; }
    //    public Grnocomp2 grnocomp { get; set; }
    //    public Non_Male5 non_male { get; set; }
    //    public Non_Pell5 non_pell { get; set; }
    //    public Ugnocomp4 ugnocomp { get; set; }
    //    public Dependent5 dependent { get; set; }
    //    public Ugunkcomp5 ugunkcomp { get; set; }
    //    public Independent5 independent { get; set; }
    //}

    //public class Gr7
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Ug15
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Male7
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Pell6
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Grcomp2
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Ugcomp5
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Grnocomp2
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Non_Male5
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Non_Pell5
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Ugnocomp4
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Dependent5
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Ugunkcomp5
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class Independent5
    //{
    //    public int? count { get; set; }
    //    public string _default { get; set; }
    //    public string deferment { get; set; }
    //    public string discharge { get; set; }
    //    public string fullypaid { get; set; }
    //    public string delinquent { get; set; }
    //    public string noprogress { get; set; }
    //    public string forbearance { get; set; }
    //    public string makingprogress { get; set; }
    //}

    //public class _3_Yr_Repayment_Suppressed
    //{
    //    public float? overall { get; set; }
    //    public float? completers { get; set; }
    //    public float? pell_grant { get; set; }
    //    public float? male_students { get; set; }
    //    public float? no_pell_grant { get; set; }
    //    public float? non_completers { get; set; }
    //    public float? female_students { get; set; }
    //    public Income8 income { get; set; }
    //    public float? dependent_students { get; set; }
    //    public float? independent_students { get; set; }
    //    public float? first_generation_students { get; set; }
    //    public float? non_first_generation_students { get; set; }
    //}

    //public class Income8
    //{
    //    public float? low_income { get; set; }
    //    public float? high_income { get; set; }
    //    public float? middle_income { get; set; }
    //}

    //public class _2_Yr_Bb_Fed_Repayment_Suppressed
    //{
    //    public Ug16 ug { get; set; }
    //    public Ugcomp6 ugcomp { get; set; }
    //}

    //public class Ug16
    //{
    //    public int? count { get; set; }
    //    public float? _default { get; set; }
    //    public float? deferment { get; set; }
    //    public float? discharge { get; set; }
    //    public float? fullypaid { get; set; }
    //    public float? delinquent { get; set; }
    //    public float? noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public float? makingprogress { get; set; }
    //}

    //public class Ugcomp6
    //{
    //    public int? count { get; set; }
    //    public float? _default { get; set; }
    //    public float? deferment { get; set; }
    //    public float? discharge { get; set; }
    //    public float? fullypaid { get; set; }
    //    public float? delinquent { get; set; }
    //    public float? noprogress { get; set; }
    //    public float? forbearance { get; set; }
    //    public float? makingprogress { get; set; }
    //}

    //public class Repayment_Cohort
    //{
    //    public float? _1_year_declining_balance { get; set; }
    //    public float? _3_year_declining_balance { get; set; }
    //    public float? _5_year_declining_balance { get; set; }
    //    public float? _7_year_declining_balance { get; set; }
    //}

    //public class Admissions
    //{
    //    public int? test_requirements { get; set; }
    //    public Admission_Rate admission_rate { get; set; }
    //    public Act_Scores act_scores { get; set; }
    //    public Sat_Scores sat_scores { get; set; }
    //}

    //public class Admission_Rate
    //{
    //    public float? overall { get; set; }
    //    public float? by_ope_id { get; set; }
    //    public float? consumer_rate { get; set; }
    //}

    //public class Act_Scores
    //{
    //    public Midpoint midpoint { get; set; }
    //    public _25Th_Percentile _25th_percentile { get; set; }
    //    public _75Th_Percentile _75th_percentile { get; set; }
    //}

    //public class Midpoint
    //{
    //    public int? math { get; set; }
    //    public int? english { get; set; }
    //    public int? writing { get; set; }
    //    public int? cumulative { get; set; }
    //}

    //public class _25Th_Percentile
    //{
    //    public int? math { get; set; }
    //    public int? english { get; set; }
    //    public int? writing { get; set; }
    //    public int? cumulative { get; set; }
    //}

    //public class _75Th_Percentile
    //{
    //    public int? math { get; set; }
    //    public int? english { get; set; }
    //    public int? writing { get; set; }
    //    public int? cumulative { get; set; }
    //}

    //public class Sat_Scores
    //{
    //    public Midpoint1 midpoint { get; set; }
    //    public Average average { get; set; }
    //    public _25Th_Percentile1 _25th_percentile { get; set; }
    //    public _75Th_Percentile1 _75th_percentile { get; set; }
    //}

    //public class Midpoint1
    //{
    //    public int? math { get; set; }
    //    public int? writing { get; set; }
    //    public int? critical_reading { get; set; }
    //}

    //public class Average
    //{
    //    public int? overall { get; set; }
    //    public int? by_ope_id { get; set; }
    //}

    //public class _25Th_Percentile1
    //{
    //    public int? math { get; set; }
    //    public int? writing { get; set; }
    //    public int? critical_reading { get; set; }
    //}

    //public class _75Th_Percentile1
    //{
    //    public int? math { get; set; }
    //    public int? writing { get; set; }
    //    public int? critical_reading { get; set; }
    //}

    /// <summary>
    /// start here
    /// </summary>

    //public class Academics
    //{
    //    [Key]
    //    public int id { get; set; }
    //    public CollegePrograms programs { get; set; }
    //    //public Program_Available program_available { get; set; }
    //    //public Program_Percentage program_percentage { get; set; }
    //    //public Program_Reporter3 program_reporter { get; set; }
    //}




    //public class CollegePrograms
    //{
    //    [Key]
    //    public int id { get; set; }
    //    //public Assoc assoc { get; set; }
    //    //public Degree degree { get; set; }
    //    //public Bachelors bachelors { get; set; }
    //    //public Certificate_Lt_1_Yr certificate_lt_1_yr { get; set; }
    //    //public Certificate_Lt_2_Yr certificate_lt_2_yr { get; set; }
    //    //public Certificate_Lt_4_Yr certificate_lt_4_yr { get; set; }
    //    //public Degree_Or_Certificate degree_or_certificate { get; set; }
    //}

    //public class Assoc
    //{
    //    [Key]
    //    public int id { get; set; }
    //    public int legal { get; set; }
    //    public int health { get; set; }
    //    public int english { get; set; }
    //    public int history { get; set; }
    //    public int library { get; set; }
    //    public int computer { get; set; }
    //    public int language { get; set; }
    //    public int military { get; set; }
    //    public int education { get; set; }
    //    public int resources { get; set; }
    //    public int biological { get; set; }
    //    public int humanities { get; set; }
    //    public int psychology { get; set; }
    //    public int agriculture { get; set; }
    //    public int engineering { get; set; }
    //    public int mathematics { get; set; }
    //    public int architecture { get; set; }
    //    public int construction { get; set; }
    //    public int communication { get; set; }
    //    public int social_science { get; set; }
    //    public int transportation { get; set; }
    //    public int multidiscipline { get; set; }
    //    public int physical_science { get; set; }
    //    public int personal_culinary { get; set; }
    //    public int visual_performing { get; set; }
    //    public int business_marketing { get; set; }
    //    public int science_technology { get; set; }
    //    public int philosophy_religious { get; set; }
    //    public int precision_production { get; set; }
    //    public int engineering_technology { get; set; }
    //    public int ethnic_cultural_gender { get; set; }
    //    public int family_consumer_science { get; set; }
    //    public int parks_recreation_fitness { get; set; }
    //    public int security_law_enforcement { get; set; }
    //    public int communications_technology { get; set; }
    //    public int mechanic_repair_technology { get; set; }
    //    public int theology_religious_vocation { get; set; }
    //    public int public_administration_social_service { get; set; }
    //}

    //public class Degree
    //{
    //    [Key]
    //    public int id { get; set; }
    //    public int legal { get; set; }
    //    public int health { get; set; }
    //    public int english { get; set; }
    //    public int history { get; set; }
    //    public int library { get; set; }
    //    public int computer { get; set; }
    //    public int language { get; set; }
    //    public int military { get; set; }
    //    public int education { get; set; }
    //    public int resources { get; set; }
    //    public int biological { get; set; }
    //    public int humanities { get; set; }
    //    public int psychology { get; set; }
    //    public int agriculture { get; set; }
    //    public int engineering { get; set; }
    //    public int mathematics { get; set; }
    //    public int architecture { get; set; }
    //    public int construction { get; set; }
    //    public int communication { get; set; }
    //    public int social_science { get; set; }
    //    public int transportation { get; set; }
    //    public int multidiscipline { get; set; }
    //    public int physical_science { get; set; }
    //    public int personal_culinary { get; set; }
    //    public int visual_performing { get; set; }
    //    public int business_marketing { get; set; }
    //    public int science_technology { get; set; }
    //    public int philosophy_religious { get; set; }
    //    public int precision_production { get; set; }
    //    public int engineering_technology { get; set; }
    //    public int ethnic_cultural_gender { get; set; }
    //    public int family_consumer_science { get; set; }
    //    public int parks_recreation_fitness { get; set; }
    //    public int security_law_enforcement { get; set; }
    //    public int communications_technology { get; set; }
    //    public int mechanic_repair_technology { get; set; }
    //    public int theology_religious_vocation { get; set; }
    //    public int public_administration_social_service { get; set; }
    //}

    //public class Bachelors
    //{
    //    [Key]
    //    public int id { get; set; }
    //    public int legal { get; set; }
    //    public int health { get; set; }
    //    public int english { get; set; }
    //    public int history { get; set; }
    //    public int library { get; set; }
    //    public int computer { get; set; }
    //    public int language { get; set; }
    //    public int military { get; set; }
    //    public int education { get; set; }
    //    public int resources { get; set; }
    //    public int biological { get; set; }
    //    public int humanities { get; set; }
    //    public int psychology { get; set; }
    //    public int agriculture { get; set; }
    //    public int engineering { get; set; }
    //    public int mathematics { get; set; }
    //    public int architecture { get; set; }
    //    public int construction { get; set; }
    //    public int communication { get; set; }
    //    public int social_science { get; set; }
    //    public int transportation { get; set; }
    //    public int multidiscipline { get; set; }
    //    public int physical_science { get; set; }
    //    public int personal_culinary { get; set; }
    //    public int visual_performing { get; set; }
    //    public int business_marketing { get; set; }
    //    public int science_technology { get; set; }
    //    public int philosophy_religious { get; set; }
    //    public int precision_production { get; set; }
    //    public int engineering_technology { get; set; }
    //    public int ethnic_cultural_gender { get; set; }
    //    public int family_consumer_science { get; set; }
    //    public int parks_recreation_fitness { get; set; }
    //    public int security_law_enforcement { get; set; }
    //    public int communications_technology { get; set; }
    //    public int mechanic_repair_technology { get; set; }
    //    public int theology_religious_vocation { get; set; }
    //    public int public_administration_social_service { get; set; }
    //}

    /// <summary>
    /// end here
    /// </summary>
    /// 


    //public class Certificate_Lt_1_Yr
    //{
    //    public int legal { get; set; }
    //    public int health { get; set; }
    //    public int english { get; set; }
    //    public int history { get; set; }
    //    public int library { get; set; }
    //    public int computer { get; set; }
    //    public int language { get; set; }
    //    public int military { get; set; }
    //    public int education { get; set; }
    //    public int resources { get; set; }
    //    public int biological { get; set; }
    //    public int humanities { get; set; }
    //    public int psychology { get; set; }
    //    public int agriculture { get; set; }
    //    public int engineering { get; set; }
    //    public int mathematics { get; set; }
    //    public int architecture { get; set; }
    //    public int construction { get; set; }
    //    public int communication { get; set; }
    //    public int social_science { get; set; }
    //    public int transportation { get; set; }
    //    public int multidiscipline { get; set; }
    //    public int physical_science { get; set; }
    //    public int personal_culinary { get; set; }
    //    public int visual_performing { get; set; }
    //    public int business_marketing { get; set; }
    //    public int science_technology { get; set; }
    //    public int philosophy_religious { get; set; }
    //    public int precision_production { get; set; }
    //    public int engineering_technology { get; set; }
    //    public int ethnic_cultural_gender { get; set; }
    //    public int family_consumer_science { get; set; }
    //    public int parks_recreation_fitness { get; set; }
    //    public int security_law_enforcement { get; set; }
    //    public int communications_technology { get; set; }
    //    public int mechanic_repair_technology { get; set; }
    //    public int theology_religious_vocation { get; set; }
    //    public int public_administration_social_service { get; set; }
    //}

    //public class Certificate_Lt_2_Yr
    //{
    //    public int legal { get; set; }
    //    public int health { get; set; }
    //    public int english { get; set; }
    //    public int history { get; set; }
    //    public int library { get; set; }
    //    public int computer { get; set; }
    //    public int language { get; set; }
    //    public int military { get; set; }
    //    public int education { get; set; }
    //    public int resources { get; set; }
    //    public int biological { get; set; }
    //    public int humanities { get; set; }
    //    public int psychology { get; set; }
    //    public int agriculture { get; set; }
    //    public int engineering { get; set; }
    //    public int mathematics { get; set; }
    //    public int architecture { get; set; }
    //    public int construction { get; set; }
    //    public int communication { get; set; }
    //    public int social_science { get; set; }
    //    public int transportation { get; set; }
    //    public int multidiscipline { get; set; }
    //    public int physical_science { get; set; }
    //    public int personal_culinary { get; set; }
    //    public int visual_performing { get; set; }
    //    public int business_marketing { get; set; }
    //    public int science_technology { get; set; }
    //    public int philosophy_religious { get; set; }
    //    public int precision_production { get; set; }
    //    public int engineering_technology { get; set; }
    //    public int ethnic_cultural_gender { get; set; }
    //    public int family_consumer_science { get; set; }
    //    public int parks_recreation_fitness { get; set; }
    //    public int security_law_enforcement { get; set; }
    //    public int communications_technology { get; set; }
    //    public int mechanic_repair_technology { get; set; }
    //    public int theology_religious_vocation { get; set; }
    //    public int public_administration_social_service { get; set; }
    //}

    //public class Certificate_Lt_4_Yr
    //{
    //    public int legal { get; set; }
    //    public int health { get; set; }
    //    public int english { get; set; }
    //    public int history { get; set; }
    //    public int library { get; set; }
    //    public int computer { get; set; }
    //    public int language { get; set; }
    //    public int military { get; set; }
    //    public int education { get; set; }
    //    public int resources { get; set; }
    //    public int biological { get; set; }
    //    public int humanities { get; set; }
    //    public int psychology { get; set; }
    //    public int agriculture { get; set; }
    //    public int engineering { get; set; }
    //    public int mathematics { get; set; }
    //    public int architecture { get; set; }
    //    public int construction { get; set; }
    //    public int communication { get; set; }
    //    public int social_science { get; set; }
    //    public int transportation { get; set; }
    //    public int multidiscipline { get; set; }
    //    public int physical_science { get; set; }
    //    public int personal_culinary { get; set; }
    //    public int visual_performing { get; set; }
    //    public int business_marketing { get; set; }
    //    public int science_technology { get; set; }
    //    public int philosophy_religious { get; set; }
    //    public int precision_production { get; set; }
    //    public int engineering_technology { get; set; }
    //    public int ethnic_cultural_gender { get; set; }
    //    public int family_consumer_science { get; set; }
    //    public int parks_recreation_fitness { get; set; }
    //    public int security_law_enforcement { get; set; }
    //    public int communications_technology { get; set; }
    //    public int mechanic_repair_technology { get; set; }
    //    public int theology_religious_vocation { get; set; }
    //    public int public_administration_social_service { get; set; }
    //}

    //public class Degree_Or_Certificate
    //{
    //    public int legal { get; set; }
    //    public int health { get; set; }
    //    public int english { get; set; }
    //    public int history { get; set; }
    //    public int library { get; set; }
    //    public int computer { get; set; }
    //    public int language { get; set; }
    //    public int military { get; set; }
    //    public int education { get; set; }
    //    public int resources { get; set; }
    //    public int biological { get; set; }
    //    public int humanities { get; set; }
    //    public int psychology { get; set; }
    //    public int agriculture { get; set; }
    //    public int engineering { get; set; }
    //    public int mathematics { get; set; }
    //    public int architecture { get; set; }
    //    public int construction { get; set; }
    //    public int communication { get; set; }
    //    public int social_science { get; set; }
    //    public int transportation { get; set; }
    //    public int multidiscipline { get; set; }
    //    public int physical_science { get; set; }
    //    public int personal_culinary { get; set; }
    //    public int visual_performing { get; set; }
    //    public int business_marketing { get; set; }
    //    public int science_technology { get; set; }
    //    public int philosophy_religious { get; set; }
    //    public int precision_production { get; set; }
    //    public int engineering_technology { get; set; }
    //    public int ethnic_cultural_gender { get; set; }
    //    public int family_consumer_science { get; set; }
    //    public int parks_recreation_fitness { get; set; }
    //    public int security_law_enforcement { get; set; }
    //    public int communications_technology { get; set; }
    //    public int mechanic_repair_technology { get; set; }
    //    public int theology_religious_vocation { get; set; }
    //    public int public_administration_social_service { get; set; }
    //}

    //public class Program_Available
    //{
    //    public bool assoc { get; set; }
    //    public bool bachelors { get; set; }
    //    public bool certificate { get; set; }
    //    public bool assoc_or_bachelors { get; set; }
    //    public bool assoc_or_bachelors_or_certificate { get; set; }
    //}

    //public class Program_Percentage
    //{
    //    public float legal { get; set; }
    //    public float health { get; set; }
    //    public float english { get; set; }
    //    public float history { get; set; }
    //    public int library { get; set; }
    //    public float computer { get; set; }
    //    public float language { get; set; }
    //    public int military { get; set; }
    //    public float education { get; set; }
    //    public float resources { get; set; }
    //    public float biological { get; set; }
    //    public float humanities { get; set; }
    //    public float psychology { get; set; }
    //    public float agriculture { get; set; }
    //    public float engineering { get; set; }
    //    public float mathematics { get; set; }
    //    public float architecture { get; set; }
    //    public float construction { get; set; }
    //    public float communication { get; set; }
    //    public float social_science { get; set; }
    //    public float transportation { get; set; }
    //    public float multidiscipline { get; set; }
    //    public float physical_science { get; set; }
    //    public float personal_culinary { get; set; }
    //    public float visual_performing { get; set; }
    //    public float business_marketing { get; set; }
    //    public float science_technology { get; set; }
    //    public float philosophy_religious { get; set; }
    //    public float precision_production { get; set; }
    //    public float engineering_technology { get; set; }
    //    public float ethnic_cultural_gender { get; set; }
    //    public float family_consumer_science { get; set; }
    //    public float parks_recreation_fitness { get; set; }
    //    public float security_law_enforcement { get; set; }
    //    public float communications_technology { get; set; }
    //    public float mechanic_repair_technology { get; set; }
    //    public float theology_religious_vocation { get; set; }
    //    public float public_administration_social_service { get; set; }
    //}

    //public class Program_Reporter3
    //{
    //    public int? programs_offered { get; set; }
    //    public Program_11 program_1 { get; set; }
    //    public Program_21 program_2 { get; set; }
    //    public Program_31 program_3 { get; set; }
    //    public Program_41 program_4 { get; set; }
    //    public Program_51 program_5 { get; set; }
    //    public Program_61 program_6 { get; set; }
    //}

    //public class Program_11
    //{
    //    public Cip_6_Digit6 cip_6_digit { get; set; }
    //}

    //public class Cip_6_Digit6
    //{
    //    public string code { get; set; }
    //    public string title { get; set; }
    //    public int? avg_month_completion { get; set; }
    //}

    //public class Program_21
    //{
    //    public Cip_6_Digit7 cip_6_digit { get; set; }
    //}

    //public class Cip_6_Digit7
    //{
    //    public string code { get; set; }
    //    public string title { get; set; }
    //    public int? avg_month_completion { get; set; }
    //}

    //public class Program_31
    //{
    //    public Cip_6_Digit8 cip_6_digit { get; set; }
    //}

    //public class Cip_6_Digit8
    //{
    //    public object code { get; set; }
    //    public object title { get; set; }
    //    public object avg_month_completion { get; set; }
    //}

    //public class Program_41
    //{
    //    public Cip_6_Digit9 cip_6_digit { get; set; }
    //}

    //public class Cip_6_Digit9
    //{
    //    public object code { get; set; }
    //    public object title { get; set; }
    //    public object avg_month_completion { get; set; }
    //}

    //public class Program_51
    //{
    //    public Cip_6_Digit10 cip_6_digit { get; set; }
    //}

    //public class Cip_6_Digit10
    //{
    //    public object code { get; set; }
    //    public object title { get; set; }
    //    public object avg_month_completion { get; set; }
    //}

    //public class Program_61
    //{
    //    public Cip_6_Digit11 cip_6_digit { get; set; }
    //}

    //public class Cip_6_Digit11
    //{
    //    public object code { get; set; }
    //    public object title { get; set; }
    //    public object avg_month_completion { get; set; }
    //}

    //public class Programs
    //{
    //    public Cip_4_Digit[] cip_4_digit { get; set; }
    //}

    //public class Cip_4_Digit
    //{
    //    public string code { get; set; }
    //    public string title { get; set; }
    //    public string ope6_id { get; set; }
    //    public int unit_id { get; set; }
    //    public School1 school { get; set; }
    //    public Credential credential { get; set; }
    //    public Counts counts { get; set; }
    //    public Repayment1 repayment { get; set; }
    //    public Debt debt { get; set; }
    //    public Earnings1 earnings { get; set; }
    //}

    //public class School1
    //{
    //    public string name { get; set; }
    //    public string type { get; set; }
    //    public int main_campus { get; set; }
    //}

    //public class Credential
    //{
    //    public int level { get; set; }
    //    public string title { get; set; }
    //}

    //public class Counts
    //{
    //    public int? ipeds_awards1 { get; set; }
    //    public int? ipeds_awards2 { get; set; }
    //}

    //public class Repayment1
    //{
    //    public _2_Yr_Bb_Fed_Comp _2_yr_bb_fed_comp { get; set; }
    //    public _3_Yr_Bb_Fed_Comp _3_yr_bb_fed_comp { get; set; }
    //}

    //public class _2_Yr_Bb_Fed_Comp
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public object discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public object forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class _3_Yr_Bb_Fed_Comp
    //{
    //    public int? count { get; set; }
    //    public object _default { get; set; }
    //    public object deferment { get; set; }
    //    public string discharge { get; set; }
    //    public object fullypaid { get; set; }
    //    public object delinquent { get; set; }
    //    public object noprogress { get; set; }
    //    public object forbearance { get; set; }
    //    public object makingprogress { get; set; }
    //}

    //public class Debt
    //{
    //    public Parent_Plus1 parent_plus { get; set; }
    //    public Staff_Grad_Plus staff_grad_plus { get; set; }
    //}

    //public class Parent_Plus1
    //{
    //    public All1 all { get; set; }
    //    public Male8 male { get; set; }
    //    public Pell7 pell { get; set; }
    //    public Not_Male1 not_male { get; set; }
    //    public Not_Pell1 not_pell { get; set; }
    //}

    //public class All1
    //{
    //    public All_Inst12 all_inst { get; set; }
    //    public Eval_Inst12 eval_inst { get; set; }
    //}

    //public class All_Inst12
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //    public int? median_payment { get; set; }
    //}

    //public class Eval_Inst12
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //    public int? median_payment { get; set; }
    //}

    //public class Male8
    //{
    //    public All_Inst13 all_inst { get; set; }
    //    public Eval_Inst13 eval_inst { get; set; }
    //}

    //public class All_Inst13
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Eval_Inst13
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Pell7
    //{
    //    public All_Inst14 all_inst { get; set; }
    //    public Eval_Inst14 eval_inst { get; set; }
    //}

    //public class All_Inst14
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Eval_Inst14
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Not_Male1
    //{
    //    public All_Inst15 all_inst { get; set; }
    //    public Eval_Inst15 eval_inst { get; set; }
    //}

    //public class All_Inst15
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Eval_Inst15
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Not_Pell1
    //{
    //    public All_Inst16 all_inst { get; set; }
    //    public Eval_Inst16 eval_inst { get; set; }
    //}

    //public class All_Inst16
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Eval_Inst16
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Staff_Grad_Plus
    //{
    //    public All2 all { get; set; }
    //    public Male9 male { get; set; }
    //    public Pell8 pell { get; set; }
    //    public Not_Male2 not_male { get; set; }
    //    public Not_Pell2 not_pell { get; set; }
    //}

    //public class All2
    //{
    //    public All_Inst17 all_inst { get; set; }
    //    public Eval_Inst17 eval_inst { get; set; }
    //}

    //public class All_Inst17
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //    public int? median_payment { get; set; }
    //}

    //public class Eval_Inst17
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //    public int? median_payment { get; set; }
    //}

    //public class Male9
    //{
    //    public All_Inst18 all_inst { get; set; }
    //    public Eval_Inst18 eval_inst { get; set; }
    //}

    //public class All_Inst18
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Eval_Inst18
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Pell8
    //{
    //    public All_Inst19 all_inst { get; set; }
    //    public Eval_Inst19 eval_inst { get; set; }
    //}

    //public class All_Inst19
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Eval_Inst19
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Not_Male2
    //{
    //    public All_Inst20 all_inst { get; set; }
    //    public Eval_Inst20 eval_inst { get; set; }
    //}

    //public class All_Inst20
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Eval_Inst20
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Not_Pell2
    //{
    //    public All_Inst21 all_inst { get; set; }
    //    public Eval_Inst21 eval_inst { get; set; }
    //}

    //public class All_Inst21
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Eval_Inst21
    //{
    //    public int? count { get; set; }
    //    public int? median { get; set; }
    //    public int? average { get; set; }
    //}

    //public class Earnings1
    //{
    //    public Highest highest { get; set; }
    //}

    //public class Highest
    //{
    //    public _1_Yr _1_yr { get; set; }
    //    public _3_Yr _3_yr { get; set; }
    //    public _2_Yr _2_yr { get; set; }
    //}

    //public class _1_Yr
    //{
    //    public int? male_median_earnings { get; set; }
    //    public int? pell_median_earnings { get; set; }
    //    public int? nonmale_median_earnings { get; set; }
    //    public int? nonpell_median_earnings { get; set; }
    //    public int? overall_median_earnings { get; set; }
    //    public int? overall_count_over_poverty_line { get; set; }
    //    public Working_Not_Enrolled4 working_not_enrolled { get; set; }
    //    public Not_Working_Not_Enrolled4 not_working_not_enrolled { get; set; }
    //}

    //public class Working_Not_Enrolled4
    //{
    //    public int? male_count { get; set; }
    //    public int? pell_count { get; set; }
    //    public int? nonmale_count { get; set; }
    //    public int? nonpell_count { get; set; }
    //    public int? overall_count { get; set; }
    //}

    //public class Not_Working_Not_Enrolled4
    //{
    //    public int? overall_count { get; set; }
    //}

    //public class _3_Yr
    //{
    //    public int? male_median_earnings { get; set; }
    //    public int? pell_median_earnings { get; set; }
    //    public int? nonmale_median_earnings { get; set; }
    //    public int? nonpell_median_earnings { get; set; }
    //    public Not_Enrolled not_enrolled { get; set; }
    //    public int? overall_median_earnings { get; set; }
    //    public int? overall_count_over_poverty_line { get; set; }
    //    public Working_Not_Enrolled5 working_not_enrolled { get; set; }
    //}

    //public class Not_Enrolled
    //{
    //    public int? male_count { get; set; }
    //    public int? pell_count { get; set; }
    //    public int? nonmale_count { get; set; }
    //    public int? nonpell_count { get; set; }
    //    public int? overall_count { get; set; }
    //}

    //public class Working_Not_Enrolled5
    //{
    //    public int? overall_count { get; set; }
    //}

    //public class _2_Yr
    //{
    //    public int? overall_median_earnings { get; set; }
    //    public int? overall_count_over_poverty_line { get; set; }
    //    public Working_Not_Enrolled6 working_not_enrolled { get; set; }
    //    public Not_Working_Not_Enrolled5 not_working_not_enrolled { get; set; }
    //}

    //public class Working_Not_Enrolled6
    //{
    //    public int? overall_count { get; set; }
    //}

    //public class Not_Working_Not_Enrolled5
    //{
    //    public int? overall_count { get; set; }
    //}

    //public class School2
    //{
    //    [Key]
    //    public int id { get; set; }
    //    public string zip { get; set; }
    //    public string city { get; set; }
    //    public string name { get; set; }
    //    public string alias { get; set; }
    //    public string state { get; set; }
    //    public int locale { get; set; }
    //    public int dolflag { get; set; }
    //    public int branches { get; set; }
    //    public int men_only { get; set; }
    //    public int operating { get; set; }
    //    public int ownership { get; set; }
    //    public int region_id { get; set; }
    //    public string accreditor { get; set; }
    //    public string school_url { get; set; }
    //    public int state_fips { get; set; }
    //    public int women_only { get; set; }
    //    public int main_campus { get; set; }
    //    public int online_only { get; set; }
    //    //public Endowment1 endowment { get; set; }
    //    public int carnegie_basic { get; set; }
    //    public int? faculty_salary { get; set; }
    //    public int ownership_peps { get; set; }
    //    public string accreditor_code { get; set; }
    //    public float? ft_faculty_rate { get; set; }
    //    public int carnegie_undergrad { get; set; }
    //    //public object degree_urbanization { get; set; }
    //    public int under_investigation { get; set; }
    //    public string price_calculator_url { get; set; }
    //    public int carnegie_size_setting { get; set; }
    //    //public Minority_Serving1 minority_serving { get; set; }
    //    public int? religious_affiliation { get; set; }
    //    public int? open_admissions_policy { get; set; }
    //    //public Title_Iv3 title_iv { get; set; }
    //    //public Degrees_Awarded1 degrees_awarded { get; set; }
    //    public int tuition_revenue_per_fte { get; set; }
    //    public int instructional_expenditure_per_fte { get; set; }
    //    //public Institutional_Characteristics1 institutional_characteristics { get; set; }
    //}

    //public class Endowment1
    //{
    //    public int? end { get; set; }
    //    public int? begin { get; set; }
    //}

    //public class Minority_Serving1
    //{
    //    public int annh { get; set; }
    //    public int nant { get; set; }
    //    public int aanipi { get; set; }
    //    public int tribal { get; set; }
    //    public int hispanic { get; set; }
    //    public int historically_black { get; set; }
    //    public int predominantly_black { get; set; }
    //}

    //public class Title_Iv3
    //{
    //    public string approval_date { get; set; }
    //    public int eligibility_type { get; set; }
    //}

    //public class Degrees_Awarded1
    //{
    //    public int highest { get; set; }
    //    public int predominant { get; set; }
    //    public int predominant_recoded { get; set; }
    //}

    //public class Institutional_Characteristics1
    //{
    //    public int level { get; set; }
    //}

    //public class Location
    //{
    //    public float lat { get; set; }
    //    public float lon { get; set; }
    //}

}




