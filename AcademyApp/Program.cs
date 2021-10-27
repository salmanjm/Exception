using AcademyApp.Controllers;
using Business.Services;
using Entities.Models;
using System;
using Utilies.Helpers;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupController groupController = new GroupController();
            MedicineController studentController = new MedicineController();
            Helper.ChangeTextColor(ConsoleColor.Blue, "Welcome");
            while (true)
            {
                ShowMenu();
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu, out menu);
                if (isTrue && menu>=1 && menu<=9)
                {
                    switch (menu)
                    {
                        case (int)Helper.Menu.CreateGroup:
                            groupController.Create();
                            break;
                        case (int)Helper.Menu.UpdateGroup:
                            break;
                        case (int)Helper.Menu.DeleteGroup:
                            groupController.Delete();
                            break;
                        case (int)Helper.Menu.GetGroupWithId:
                            break;
                        case (int)Helper.Menu.GetGroupWithName:
                            break;
                        case (int)Helper.Menu.GetAllGroup:
                            groupController.GetAll();
                            break;
                        case (int)Helper.Menu.GetGroupsWithSize:
                            groupController.GetGroupsWithSize();
                            break;
                        case (int)Helper.Menu.CreateMedicine:
                            groupController.GetAll();
                            studentController.Create();
                            break;
                        case (int)Helper.Menu.GetAllMedicineWithGroup:
                            groupController.GetAll();
                            studentController.GetAllMedicineWithGroup();
                            break;
                    }
                }
                else if (menu == 0)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkCyan, "Bye Bye");
                    break;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Please, select correct option");
                }
            }
        }

        static void ShowMenu()
        {
            Helper.ChangeTextColor(ConsoleColor.Green,
                    "1-Create Group, 2-Update Group, 3-Delete Group, 4-Get Group with Id," +
                    "5-Get Group with Name, 6-All Group, 7- Get Groups with number of boxes,8-Create Medicine,0-Exit");
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Select Option Number:");
        }
    }
}
