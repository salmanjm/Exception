using Entities.Interfaces;

namespace Entities.Models
{
    public class Group:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfBoxes { get; set; }
    }
}
