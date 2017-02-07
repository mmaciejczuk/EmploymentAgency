using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class JobOffer
    {
        public JobOffer()
        {

        }

        [Key]
        [Display(Name = "Id:")]
        public int Id { get; set; }
        [Display(Name = "Tytuł oferty:")]
        [Required]
        [MaxLength(160)]
        public string NameOfOffer { get; set; }
        [Display(Name = "Nazwa stanowiska:")]
        [Required]
        [MaxLength(160)]
        public string Position { get; set; }
        [Display(Name = "Miasto:")]
        [Required]
        [MaxLength(160)]
        public string City { get; set; }
        [Display(Name = "Wynagrodzenie od:")]
        [Required]
        public int SalaryFrom { get; set; }
        [Display(Name = "Wynagrodzenie do:")]
        [Required]
        public int SalaryTo { get; set; }
        [Display(Name = "Czy aktywny:")]
        [Required]
        public bool IsActive { get; set; }
        [Display(Name = "Czy usunięty:")]
        [Required]
        public bool IsDeleted { get; set; }
        [Display(Name = "Data dodania:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime AddedDate { get; set; }
        [Display(Name = "Data wygaśnięcia:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime ExpirationDate { get; set; }

        public JobCategory JobCategory { get; set; }
        public Company Company { get; set; }
        public User Users { get; set; }
    }
}