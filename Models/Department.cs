using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BussinessManager3.Models
{
    public class Department
    {
        public Department()
        {
            Employees = new List<Employee>();
        }

        [Key]
        public int DepartmentId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Field { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}