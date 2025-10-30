using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Core.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Your Name")]
        [StringLength(30)]
        public string FullName { get; set; }
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Please Enter Email address")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Your Phone Number")]        
        [Phone]
        public string PhoneNumber { get; set; }
        public string ProblemDomainOfProject { get; set; }
        public string Budget { get; set; }
        public DateTime Timeline { get; set; }
        public string ExampleWebsiteURL { get; set; }
        [NotMapped]
        public IFormFile FileUrl { get; set; }
        public string Discover { get; set; }
        [NotMapped]
        public string[] ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
