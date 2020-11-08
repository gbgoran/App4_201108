using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;

namespace App4_201108.Models
{
    public class Issue
    {
        [Key]
        public int IssueId { get; set; }

        [Key]
        public int CustomerId { get; set; }

#nullable enable
        public string? Title { get; set; }
#nullable restore
        [Required]
        public string Description { get; set; }
        [Required]
        public string Created { get; set; }
        [Required]
        public Customer customer { get; set; }
        
        public ICollection<Comment> Comments { get; set; }

    }
}