using Core.Entities.ViewModel;
using Core.Interface;
using System.Net;
using System.Net.Mail;

namespace Infrastructure.Repository
{
    public class EmailRepository : IEmail
    {
        public void SendCareerEmailForClient(ViewModels viewModel, string subject , string body)
        {

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            //create the mail message 
            MailMessage mail = new MailMessage();

            //set the addresses 
            mail.From = new MailAddress("career@majesticagency.net"); //IMPORTANT: This must be same as your smtp authentication address.
            mail.To.Add(viewModel.Career.EmailAddress);

            //set the content 
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            //send the message 
            SmtpClient smtp = new SmtpClient("mail.majesticagency.net");

            //IMPORANT:  Your smtp login email MUST be same as your FROM address. 
            NetworkCredential Credentials = new NetworkCredential("career@majesticagency.net", "Career@2022");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = Credentials;
            smtp.Port = 587;    //alternative port number is 8889
            smtp.EnableSsl = false;
            smtp.Send(mail);
            smtp.Dispose();

        }
        public void SendOrderEmailForClient(ViewModels viewModel, string subject, string body)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            //create the mail message 
            MailMessage mail = new MailMessage();

            //set the addresses 
            mail.From = new MailAddress("info@majesticagency.net"); //IMPORTANT: This must be same as your smtp authentication address.
            mail.To.Add(viewModel.Order.Email);

            //set the content 
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            //send the message 
            SmtpClient smtp = new SmtpClient("mail.majesticagency.net");

            //IMPORANT:  Your smtp login email MUST be same as your FROM address. 
            NetworkCredential Credentials = new NetworkCredential("info@majesticagency.net", "majestic@MA2022");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = Credentials;
            smtp.Port = 587;    //alternative port number is 8889
            smtp.EnableSsl = false;
            smtp.Send(mail);
            smtp.Dispose();
        }
        public void SendCareerEmailForCompany(ViewModels viewModel, string subject, string body)
        {

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            //create the mail message 
            MailMessage mail = new MailMessage();

            //set the addresses 
            mail.From = new MailAddress("career@majesticagency.net"); //IMPORTANT: This must be same as your smtp authentication address.
            mail.To.Add("career@majesticagency.net");

            //set the content 
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            if (viewModel.Career.CV.Length > 0)
            {
                string fileName = Path.GetFileName(viewModel.Career.CV.FileName);
                mail.Attachments.Add(new Attachment(viewModel.Career.CV.OpenReadStream(), fileName));
            }
            //send the message 
            SmtpClient smtp = new SmtpClient("mail.majesticagency.net");

            //IMPORANT:  Your smtp login email MUST be same as your FROM address. 
            NetworkCredential Credentials = new NetworkCredential("career@majesticagency.net", "Career@2022");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = Credentials;
            smtp.Port = 587;    //alternative port number is 8889
            smtp.EnableSsl = false;
            smtp.Send(mail);
            smtp.Dispose();

        }
        public void SendOrderEmailForCompany(ViewModels viewModel, string subject, string body)
        {

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            //create the mail message 
            MailMessage mail = new MailMessage();

            //set the addresses 
            mail.From = new MailAddress("info@majesticagency.net"); //IMPORTANT: This must be same as your smtp authentication address.
            mail.To.Add("info@majesticagency.net");

            //set the content 
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            if (viewModel.Order.FileUrl.Length > 0)
            {
                string fileName = Path.GetFileName(viewModel.Order.FileUrl.FileName);
                mail.Attachments.Add(new Attachment(viewModel.Order.FileUrl.OpenReadStream(), fileName));
            }
            //send the message 
            SmtpClient smtp = new SmtpClient("mail.majesticagency.net");

            //IMPORANT:  Your smtp login email MUST be same as your FROM address. 
            NetworkCredential Credentials = new NetworkCredential("info@majesticagency.net", "majestic@MA2022");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = Credentials;
            smtp.Port = 587;    //alternative port number is 8889
            smtp.EnableSsl = false;
            smtp.Send(mail);
            smtp.Dispose();
        }
    }
}
