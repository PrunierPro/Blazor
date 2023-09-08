using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace TpBonNombre.Models
{
    public enum Color
    {
        Red,
        Blue,
        Green,
        Yellow,
        Magenta,
        Cyan,
        Orange,
        Brown,
        Purple,
        Pink,
        White,
        Grey,
        Black
    }
    public class Person
    {
        [Required]
        public string Name { get; set; }
        [Required, RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Must be a valid email address. Ex: person@email.com")]
        public string Email { get; set; }
        [Required, RegularExpression("\\d+\\s[\\D]+", ErrorMessage = "Must be a valid home address. Ex: 1 Rue de la Rue")]
        public string Address { get; set; }
        [Required, RegularExpression("\\d{5}", ErrorMessage = "Must be a valid postal code. Ex: 59500"), StringLength(5, MinimumLength = 5, ErrorMessage = "Must be exactly 5 numbers long.")]
        public string PostalCode { get; set; }
        [Required, Range(1, 125)]
        public int Age { get; set; }
        public DateTime DoB { get; set; } = new DateTime(1999, 12, 31);
        public bool Married { get; set; }
        [Required]
        public Color FavColor { get; set; }

    }
}
