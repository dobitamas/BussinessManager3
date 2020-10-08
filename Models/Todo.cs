using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BussinessManager3.Models
{
    public class Todo
    {
        [Key]
        public int ProblemId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Descrpition { get; set; }

        [Required]
        public bool IsDone { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}