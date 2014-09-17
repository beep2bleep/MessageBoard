using System;
using System.Diagnostics;

namespace MessageBoard.Serivces
{
    public class MockMailService : IMailService
    {
        #region IMailService Members

        public bool SendMail(string from, string to, string subject, string body)
        {
            Debug.WriteLine(String.Concat("SendMail: ", subject));
            return true;
        }

        #endregion
    }
}