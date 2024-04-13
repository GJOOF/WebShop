
using System.ComponentModel.DataAnnotations;
using Webshop.Models.Users;

namespace Webshop.Models.Users.Roles
{
    public class Client : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9\s,'-]*$", ErrorMessage = "Некорректный формат адреса")]
        public string Address { get; set; }
        [Phone(ErrorMessage = "Некорректный формат телефона")]
        public string Phone { get; set; }
        public Client(int userId, string username, string password, string email, DateTime createdAt, string firstname, string lastname, string address, string phone) : base(userId, username, password, email)
        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            Phone = phone;
        }
    }
}
