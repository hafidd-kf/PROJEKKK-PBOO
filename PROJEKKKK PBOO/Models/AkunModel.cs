
namespace PROJEKKKK_PBOO.Models
{
    public class AkunModel
    {
        public bool ValidasiLogin(string username, string password)
        {
            return username == "owner" && password == "owner123";
        }
    }
}
