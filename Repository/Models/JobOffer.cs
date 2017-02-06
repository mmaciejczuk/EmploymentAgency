using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository.Models
{
    public class JobOffer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int SalaryFrom { get; set; }
        public int SalaryTo { get; set; }
    }
}