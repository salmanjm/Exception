using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helpers;

namespace AcademyApp.Controllers
{
    public class MedicineController
    {
        private MedicineService medicineService { get; }
        public MedicineController()
        {
            medicineService = new MedicineService();
        }
        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Select possible group:");
            string groupName = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter medicine name:");
            string name = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Enter medicine type:");
            string type = Console.ReadLine();
            Medicine medicine = new Medicine { Name = name, Type = type };
            Medicine newMed = medicineService.Create(medicine, groupName);
            if (newMed != null)
            {
                Helper.ChangeTextColor(ConsoleColor.Green, 
                    $"New Student is Created - {newMed.Name} {newMed.Type}");
                return;
            }
            //Helper.ChangeTextColor(ConsoleColor.Red,
            //    $"Couldn't find such as Group - {groupName}");
        }
        public void GetAllMedicineWithGroup()
        {
            Helper.ChangeTextColor(ConsoleColor.Blue, "Select possible group:");
            string groupName = Console.ReadLine();
            List<Medicine> students = medicineService.GetAll(groupName);
            if (students != null)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"Group {groupName}:");
                foreach (var item in students)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green,
                    $"{item.Id} - {item.Name} {item.Type}");
                }
                return;
            }
            //Helper.ChangeTextColor(ConsoleColor.Red,
            //    $"Couldn't find such as Group - {groupName}");
        }
    }
}
