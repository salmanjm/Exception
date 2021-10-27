using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Services
{
    public class MedicineService : IMedicine
    {
        private MedicineRepository medicineRepository { get; }
        private GroupService groupService { get; }
        private static int count;
        public MedicineService()
        {
            medicineRepository = new MedicineRepository();
            groupService = new GroupService();
        }
        public Medicine Create(Medicine medicine, string groupName)
        {
            try
            {
                Group dbGroup = medicineRepository.Get(groupName);
                if (dbGroup != null)
                {
                    medicine.Group = dbGroup;
                    medicine.Id = count;
                    medicineRepository.Create(medicine);
                    count++;
                    return medicine;
                }
                else
                {
                    throw new MedicineException("There isnt such as type");

                }
            }
            catch (MedicineException ex)
            {

                Console.WriteLine("There isnt such as type",ex.Message);
                return default;
            }
        }

        public Medicine Create(object medicine, string groupName)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> GetAll(string groupName)
        {
            Group dbGroup = medicineRepository.Get(groupName);
            if (dbGroup != null)
            {
                return medicineRepository.GetAll(s => s.Group.Name == dbGroup.Name);
            }
            else
            {
                return null;
            }
        }

        public Medicine Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Medicine Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> Get(string name)
        {
            throw new NotImplementedException();
        }

        

        public List<Medicine> GetAll()
        {
            throw new NotImplementedException();
        }

        public Medicine Update(Medicine medicine, string groupName)
        {
            throw new NotImplementedException();
        }
    }
}
