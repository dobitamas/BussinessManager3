using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussinessManager3.Models
{
    public interface IGroupRepository
    {
        Group GetGroup(int Id);

        IEnumerable<Group> GetAllGroups();

        Group Add(Group group);

        Group Update(Group group);

        Group Delete(int Id);
    }
}