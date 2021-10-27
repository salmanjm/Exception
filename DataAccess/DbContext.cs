using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public static class DbContext
    {
        public static List<Medicine> Medicines { get; }
        public static List<Group> Groups { get; }
        static DbContext()
        {
            Medicines = new List<Medicine>();
            Groups = new List<Group>();
        }
    }
}
