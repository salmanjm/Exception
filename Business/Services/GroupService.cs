using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class GroupService : IGroup
    {
        public GroupRepository groupRepository { get; set; }
        private static int count { get; set; }
        public GroupService()
        {
            groupRepository = new GroupRepository();
        }
        
        /// <summary>
        /// For create new group
        /// </summary>
        /// <param name="group">New Created Group</param>
        /// <returns></returns>
        public Group Create(Group group)
        {
            try
            {
                group.Id = count;
                Group isExist = 
                    groupRepository.Get(g => g.Name.ToLower() == group.Name.ToLower());
                if (isExist != null) 
                    return null;
                groupRepository.Create(group);
                count++;
                return group;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Group Delete(int Id)
        {
            Group dbGroup = groupRepository.Get(g => g.Id == Id);
            if (dbGroup != null)
            {
                groupRepository.Delete(dbGroup);
                return dbGroup;
            }
            else
            {
                return null;
            }
        }

        public Group Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Group Get(string Name)
        {
            return groupRepository.Get(g => g.Name.ToLower() == Name.ToLower());
        }

        public List<Group> GetAll()
        {
            return groupRepository.GetAll();
        }

        public List<Group> GetAll(int NumberOfBoxes)
        {
            return groupRepository.GetAll(g => g.NumberOfBoxes == NumberOfBoxes);
        }

        public Group Update(int Id, Group group)
        {
            throw new NotImplementedException();
        }
    }
}
