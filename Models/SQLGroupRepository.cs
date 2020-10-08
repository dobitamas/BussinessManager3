using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussinessManager3.Models
{
    public class SQLGroupRepository : IGroupRepository
    {
        private readonly AppDbContext context;

        public SQLGroupRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Group Add(Group group)
        {
            context.Groups.Add(group);
            context.SaveChanges();
            return group;
        }

        public Group Delete(int Id)
        {
            Group group = context.Groups.Find(Id);

            if (group != null)
            {
                context.Groups.Remove(group);
                context.SaveChanges();
            }

            return group;
        }

        public IEnumerable<Group> GetAllGroups()
        {
            return context.Groups;
        }

        public Group GetGroup(int Id)
        {
            return context.Groups.Find(Id);
        }

        public Group Update(Group groupChanges)
        {
            var group = context.Groups.Attach(groupChanges);
            group.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return groupChanges;
        }
    }
}