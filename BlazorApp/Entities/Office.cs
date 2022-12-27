using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Entities
{
    public class Office
    {
        public int Id { get; set; }

        [Required][RegularExpression(@"^[1-9]{1}[0-9]*$", ErrorMessage = "Номер кабинета не может быть ровна или меньше нуля")]
        public int Number { get; set; }

        public ICollection<Contact> Contacts { get; set; }
    }
}
