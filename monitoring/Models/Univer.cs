using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace monitoring.Models
{
    internal class Univer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? FullName{ get; set; }

        public virtual ObservableCollectionListSource<Cathedra> Cathedra { get; } => new();
    }
}
