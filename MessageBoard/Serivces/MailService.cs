using System;
using System.Net.Mail;

namespace MessageBoard.Serivces
{
    public class MailService : IMailService
    {
        #region IMailService Members

        public bool SendMail(string from, string to, string subject, string body)
        {
            try
            {
                var msg = new MailMessage(from, to, subject, body);

                var client = new SmtpClient();
                client.Send(msg);
            }
            catch (Exception)
            {
                //TODO: Logging
                return false;

            }
            return true;
        }

        #endregion
    }
}