using Entities.Models;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface IMedicine
    {
        Medicine Create(Medicine medicine, string groupName);
        Medicine Delete(int id);
        Medicine Update(Medicine medicine, string groupName);
        Medicine Get(int id);
        List<Medicine> Get(string name);
        List<Medicine> GetAll(string groupName);
        List<Medicine> GetAll();

    }
}
