using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Entities
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = $"Поле 'Имя' не может содержать более 100 символов")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^((\+7|7|8)+([0-9]){10})$", ErrorMessage = "Введите номер формата +7/7/80000000000")]
        public string Phone { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Поле 'Aдрес' не может содержать более 150 символов")]
        public string Address { get; set; }

        [Required]
        public int Office { get; set; }

        [Required]
        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
