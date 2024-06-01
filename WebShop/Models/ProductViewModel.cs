using System.ComponentModel.DataAnnotations;

namespace Webshop.Models
{
    public class ProductViewModel
    {
        private static int unicId;
        public Guid Id { get; set; }
        [Required(ErrorMessage = "������� ��������")]
        public string Name { get; set; }
        [Required(ErrorMessage = "������� ����")]
        public decimal Cost { get; set; }
        [Required(ErrorMessage = "������� ��������")]
        public string Description { get; set; }
        public string ImagePath;
    }
}
