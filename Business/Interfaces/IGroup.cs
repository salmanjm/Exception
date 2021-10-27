using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IGroup
    {
        Group Create(Group group);
        Group Update(int Id,Group group);
        Group Delete(int Id);
        Group Get(int Id);
        Group Get(string Name);
        List<Group> GetAll();
        List<Group> GetAll(int MaxSize);

    }
}
