using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BussinessManager3.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int TodoId { get; set; }

        [ForeignKey("TodoId")]
        public Todo Todo { get; set; }

        [Required]
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}