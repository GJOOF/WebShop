using System.ComponentModel.DataAnnotations;

namespace Webshop.Models.Users.Roles
{
    public class Roles
    {
        public Guid roleId { get; set; }
        [Required(ErrorMessage = "Введите название роли.")]
        public string? roleName { get; set; }
        public string? roleDescription { get; set; }
    }
}
