using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace KCC_TOOL.Model
{
    public class SendMessage
    {
        public static void Email(MailAddress From, MailAddress To, string Subject, string Body, string Server, int Port
            , string Account, string Password, bool IsBodyHtml, bool EnableSsl, bool UseDefaultCredentials)
        {

            MailMessage mail = new MailMessage(From, To)
            {
                IsBodyHtml = IsBodyHtml,
                Subject = Subject,
                Body = Body
            };

            SmtpClient smtp = new SmtpClient();
            smtp.Host = Server;
            smtp.Port = Port;
            smtp.EnableSsl = EnableSsl;
            //smtp.UseDefaultCredentials = false;
            smtp.UseDefaultCredentials = UseDefaultCredentials;   //大車正式環境要加這行才能成功寄信
            smtp.Credentials = new NetworkCredential(Account, Password);
            
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Send(mail);

        }

    }
}
