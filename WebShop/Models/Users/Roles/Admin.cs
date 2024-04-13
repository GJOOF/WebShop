using Webshop.Models.Users;
namespace Webshop.Models.Users.Roles
{
    public class Admin : User
    {
        public bool IsAdmin { get; set; }
        public Admin(int userId, string username, string password, string email, DateTime createdAt) : base(userId, username, password, email)
        {

        }
    }
}
