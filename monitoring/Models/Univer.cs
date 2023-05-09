using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace monitoring.Models
{
    public class Univer
    {
        public int UniverId { get; set; }
        public string Name { get; set; }
        public string? FullName{ get; set; }

        public virtual ObservableCollectionListSource<Cathedra> Cathedras { get; } = new();
    }
}
