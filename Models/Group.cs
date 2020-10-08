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

        public List<Employee> Employees { get; set; }
    }
}