﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussinessManager3.Models
{
    public interface IDepartmentRepository
    {
        Department GetDepartment(int Id);

        IEnumerable<Department> GetAllDepartment();

        Department Add(Department department);

        Department Update(Department departmentChanges);

        Department Delete(int Id);
    }
}