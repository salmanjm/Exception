using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        public bool Create(Group entity)
        {
            try
            {
                DbContext.Groups.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Group entity)
        {
            try
            {
                DbContext.Groups.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Group Get(Predicate<Group> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Groups[0]
                    : DbContext.Groups.Find(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Group> GetAll(Predicate<Group> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Groups
                    : DbContext.Groups.FindAll(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(Group entity)
        {
            try
            {
                Group dbGroup = Get(s => s.Id == entity.Id);
                dbGroup = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
