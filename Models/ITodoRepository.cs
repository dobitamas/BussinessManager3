using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussinessManager3.Models
{
    public interface ITodoRepository
    {
        Todo GetProblem(int Id);

        IEnumerable<Todo> GetAllTodos();

        Todo Add(Todo todo);

        Todo Update(Todo todo);

        Todo Delete(int Id);
    }
}