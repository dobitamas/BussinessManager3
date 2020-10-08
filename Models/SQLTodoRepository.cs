using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussinessManager3.Models
{
    public class SQLTodoRepository : ITodoRepository
    {
        private readonly AppDbContext context;

        public SQLTodoRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Todo Add(Todo todo)
        {
            context.Todos.Add(todo);
            context.SaveChanges();
            return todo;
        }

        public Todo Delete(int Id)
        {
            Todo todo = context.Todos.Find(Id);

            if (todo != null)
            {
                context.Todos.Remove(todo);
                context.SaveChanges();
            }

            return todo;
        }

        public IEnumerable<Todo> GetAllTodos()
        {
            return context.Todos;
        }

        public Todo GetProblem(int Id)
        {
            return context.Todos.Find(Id);
        }

        public Todo Update(Todo todoChanges)
        {
            var todo = context.Todos.Attach(todoChanges);
            todo.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return todoChanges;
        }
    }
}