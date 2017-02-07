﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class Company
    {
        public Company()
        {
            this.JobOffers = new HashSet<JobOffer>();
        }

        [Key]
        [Display(Name = "Id:")]
        public int Id { get; set; }
        [Display(Name = "Nazwa firmy:")]
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
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
        public  virtual ICollection<JobOffer> JobOffers { get; set; }
    }
}