using System.ComponentModel.DataAnnotations;

namespace Webshop.Models
{
    public class Role
    {
        [Required]
        public string Name { get; set; }
    }
}
