using System.ComponentModel.DataAnnotations;

namespace Webshop.Models
{
    public class ProductViewModel
    {
        private static int unicId;
        public Guid Id { get; set; }
        [Required(ErrorMessage = "¬ведите название")]
        public string Name { get; set; }
        [Required(ErrorMessage = "¬ведите цену")]
        public decimal Cost { get; set; }
        [Required(ErrorMessage = "¬ведите описание")]
        public string Description { get; set; }
        public string ImagePath;
    }
}
