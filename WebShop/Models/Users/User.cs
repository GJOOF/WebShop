using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Webshop.Models.Users
{
    public class User
    {
        public int IdCreat = 0;
        public int UserId { get; set; }
        public int RoleId { get; set; }
        [Required(ErrorMessage = "Имя пользователя обязательно")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Пароль обязателен")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Некорректный формат Email")]
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }

        public User(int userId, string username, string password, string email)
        {
            UserId = IdCreat++;
            Username = username;
            Password = password;
            Email = email;
        }
    }
}
