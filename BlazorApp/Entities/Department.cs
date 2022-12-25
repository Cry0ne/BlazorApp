using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Entities
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = $"Поле 'Название' не может содержать более 100 символов")]
        public string Name { get; set; }

        public ICollection<Contact> Contacts { get; set; }
    }
}
