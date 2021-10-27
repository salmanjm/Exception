using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    public class MedicineRepository : IRepository<Medicine>
    {
        public bool Create(Medicine entity)
        {
            try
            {
                DbContext.Medicines.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Medicine entity)
        {
            try
            {
                DbContext.Medicines.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Group Get(string groupName)
        {
            throw new NotImplementedException();
        }

        public Medicine Get(Predicate<Medicine> filter = null)
        {
            try
            {
                return filter==null ? DbContext.Medicines[0]
                    : DbContext.Medicines.Find(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Medicine> GetAll(Predicate<Medicine> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Medicines
                    : DbContext.Medicines.FindAll(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(Medicine entity)
        {
            try
            {
                Medicine dbMedicine = Get(s => s.Id == entity.Id);
                dbMedicine = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
