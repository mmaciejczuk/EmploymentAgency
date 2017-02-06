using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class Email
    {
        [Key]
        [Display(Name = "Id:")]
        public int Id { get; set; }
        [Display(Name = "Tytuł wiadomości:")]
        [Required]
        [MaxLength(160)]
        public string Subject { get; set; }
        [Display(Name = "Treść wiadomości:")]
        [Required]
        [MaxLength(500)]
        public string Content { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataSent { get; set; }
    }
}