using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string BackgroundDetail { get; set; }
        public List<SubService> subServices { get; set; }

    }
}
