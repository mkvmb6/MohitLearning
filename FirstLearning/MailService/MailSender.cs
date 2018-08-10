using System;

namespace MailService
{
    public class MailSender
    {
        public void SendMail(Mail mail,string videoTitle)
        {
            Console.WriteLine("Mail sent."+videoTitle+"  has been compressed ");
        }
    }
}