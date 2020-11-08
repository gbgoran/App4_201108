using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;

namespace App4_201108.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string FullName { get; set; }
        [Required]
        public string CompanyName { get; set; }

        public int ContactNumber { get; set; }

        public ICollection<Issue> Issues { get; set; }
    }
}
