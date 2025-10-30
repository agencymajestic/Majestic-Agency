using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Career
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Your Name")]
        [StringLength(50)]
        public string FullName { get; set; }
        public int Age { get; set; }
        public string MaritalStatus { get; set; }
        [Required(ErrorMessage = "Please Enter Email address")]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }
        public string CurrentResidence { get; set; }
        public string WorkingField { get; set; }
        public string JobTitle { get; set; }
        [Required(ErrorMessage = "select any one option")]
        public string Q1 { get; set; }
        [Required(ErrorMessage = "select any one option")]
        public string Q2 { get; set; }
        [Required(ErrorMessage = "select any one option")]
        public string Q3 { get; set; }
        [Required(ErrorMessage = "select any one option")]
        public string Q4 { get; set; }
        public int NumOfExperience { get; set; }
        public string CurrentWork { get; set; }
        public int ExpectedSalary  { get; set; }
        public string Features { get; set; }
        public string BehanceLink { get; set; }
        [NotMapped]
        [Required(ErrorMessage="Please Uploade Your CV or Resume")]
        public IFormFile CV { get; set; }
        public string Note { get; set; }

    }
}
