using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helpers;

namespace AcademyApp.Controllers
{
    public class GroupController
    {
        public GroupService groupService { get; }
        public GroupController()
        {
            groupService = new GroupService();
        }
        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter Group name:");
            string name = Console.ReadLine();
        EnterName: Helper.ChangeTextColor(ConsoleColor.Cyan, "Enter Group max number of boxes:");
            string size = Console.ReadLine();
            int NumberOfBoxes;
            bool isTrueSize = int.TryParse(size, out NumberOfBoxes);
            if (isTrueSize)
            {
                Group group = new Group { Name = name, NumberOfBoxes = NumberOfBoxes };
                if (groupService.Create(group) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, $"{group.Name} created");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, "Something is wrong!!!");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, "Enter Correct Size");
                goto EnterName;
            }
        }

        public void GetAll()
        {
            Helper.ChangeTextColor(ConsoleColor.Yellow, "All groups:");
            foreach (Group group in groupService.GetAll())
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"{group.Id} - {group.Name}");
            }
        }
        public void Delete()
        {
            GetAll();
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter group id:");
            string input = Console.ReadLine();
            int groupId;
            bool isTrue = int.TryParse(input, out groupId);
            if (isTrue)
            {
                if (groupService.Delete(groupId) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.Green, "Group is deleted");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.Red, $"{groupId} is not find");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Red, $"Please, select correct format");
            }

        }

        public void GetGroupsWithSize()
        {
            Helper.ChangeTextColor(ConsoleColor.Yellow, "Enter group size:");
            string input = Console.ReadLine();
            int NumberOfBoxes;
            bool isTrue = int.TryParse(input, out NumberOfBoxes);
            if (isTrue)
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"Groups which size is {NumberOfBoxes}:");
                foreach (var item in groupService.GetAll(NumberOfBoxes))
                {
                    Helper.ChangeTextColor(ConsoleColor.Cyan, item.Name);
                }
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.Red, $"Please, select correct format");
        }
    }
}
