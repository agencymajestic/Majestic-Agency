using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IService
    {
        Task<Service> GetService(int id);
        Task<List<Service>> GetServices();

    }
}
