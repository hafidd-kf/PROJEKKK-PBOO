namespace PROJEKKKK_PBOO.Controller
{
    public class LoginController
    {
        private string usernameOwner = "owner";
        private string passwordOwner = "montera123";

        public bool ProsesLogin(string username, string password)
        {
            return username == usernameOwner &&
                   password == passwordOwner;
        }
    }
}
