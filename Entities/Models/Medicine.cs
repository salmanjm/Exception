using Entities.Interfaces;

namespace Entities.Models
{
    public class Medicine: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Group Group { get; set; }
    }
}
