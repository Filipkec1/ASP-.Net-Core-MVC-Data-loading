using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Zadatak.Model
{
    public class Person
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Osoba obavezno mora imati ime")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Osoba obavezno mora imati prezime")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Grad obavezno mora imati ime")]
        public string CityName { get; set; }

        [Required(ErrorMessage = "Osoba obavezno mora imati postanski broj")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Poštanski broja mora sadrži točno 5 znamenki.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Poštanski broj smije sadržavati samo znamenke.")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Osoba obavezno mora imati mobilni broj")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Mobilni broja mora sadrži točno 11 znamenki.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Mobilni broj smije sadržavati samo znamenke.")]
        public string MobileNumber { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
