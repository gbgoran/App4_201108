using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;

namespace App4_201108.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Key]
        public int IssueId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Created { get; set; }

        public Issue Issue { get; set; }

    }
}