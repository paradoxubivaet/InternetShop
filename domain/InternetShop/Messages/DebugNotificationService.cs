using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace InternetShop.Messages
{
    public class DebugNotificationService : INotificationService
    {
        public void SendConfirmationCode(string cellPhone, int code)
        {
            Debug.WriteLine("Cell phone: {0}, code: {1:0000}.", cellPhone, code);
        }

        public void StartProcess(Order order)
        {
            using(var client = new SmtpClient()) 
            {
                var message = new MailAddress("from@at.my.domain", "to@at.my.domain");
                message.Subject = "Заказ #" + order.Id;
            }
        }
    }
}
