using System;
using System.Collections.Generic;
using System.Text;

namespace Utilies.Helpers
{
    public static class Helper
    {
        public static void ChangeTextColor(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public enum Menu
        {
            Exit,
            CreateGroup,
            UpdateGroup,
            DeleteGroup,
            GetGroupWithId,
            GetGroupWithName,
            GetAllGroup,
            GetGroupsWithSize,
            CreateMedicine,
            GetAllMedicineWithGroup
        }
    }
}
