using Core.Entities;
using Core.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IEmail
    {
        void SendCareerEmailForClient(ViewModels viewModel, string subject, string body);
        void SendCareerEmailForCompany(ViewModels viewModel, string subject, string body);
        void SendOrderEmailForClient(ViewModels viewModel, string subject, string body);
        void SendOrderEmailForCompany(ViewModels viewModel, string subject, string body);

    }
}
