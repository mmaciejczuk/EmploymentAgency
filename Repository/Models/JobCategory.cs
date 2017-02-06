using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class JobCategory
    {
        [Key]
        [Display(Name = "Id:")]
        public int Id { get; set; }
        [Display(Name = "Nazwa kategorii:")]
        [Required]
        public string Name { get; set; }
    }
}