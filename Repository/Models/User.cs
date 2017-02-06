using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class User
    {
        [Key]
        [Display(Name = "Id:")]
        public int Id { get; set; }
        [Display(Name = "Imię użytkownika:")]
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        [Display(Name = "Nazwisko użytkownika:")]
        [Required]
        [MaxLength(60)]
        public string Surname { get; set; }
        [Display(Name = "Data urodzenia:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime? DateOfBirth { get; set; }
        [Display(Name = "Adres email:")]
        [Required]
        [MaxLength(160)]
        public string Email { get; set; }
        [Display(Name = "Ulica i numer:")]
        [Required]
        [MaxLength(100)]
        public string Street { get; set; }
        [Display(Name = "Kod pocztowy:")]
        [Required]
        [MaxLength(10)]
        public string Code { get; set; }
        [Display(Name = "Miasto:")]
        [Required]
        [MaxLength(100)]
        public string City { get; set; }
        public bool IsActive { get; set; }
        [Display(Name = "Data dodania:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime AddedDate { get; set; }

        [Required]
        public Role Role { get; set; }
    }
}