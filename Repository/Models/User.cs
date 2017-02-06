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

        public string Email { get; set; }
        public string Street { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }
        [Display(Name = "Data dodania:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime AddedDate { get; set; }

        public Role Role { get; set; }
    }
}