using System.ComponentModel;

namespace monitoring.Models
{
    public class Cathedra
    {
        public int CathedraId { get; set; }
        public string Name { get; set; }
        public string? FullName { get; set; }

        public int UniverId { get; set; }
        public virtual Univer Univer { get; set; } = null!;
    }
}
