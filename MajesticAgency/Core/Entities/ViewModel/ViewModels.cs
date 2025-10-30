using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.ViewModel
{
    public class ViewModels
    {
        public List<Service> Services { get; set; }
        public List<SubService> SubServices { get; set; }
        public Order Order { get; set; }
        public Career Career { get; set; }


    }
}
