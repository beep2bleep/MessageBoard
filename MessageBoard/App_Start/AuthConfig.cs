using Microsoft.Web.WebPages.OAuth;

namespace MessageBoard
{
    public static class AuthConfig
    {

        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            OAuthWebSecurity.RegisterFacebookClient("742132622525220", "a1545b740324055fb254cfbd1f8f9db1");

            OAuthWebSecurity.RegisterGoogleClient();
        }

    }
}