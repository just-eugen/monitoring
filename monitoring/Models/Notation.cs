using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace monitoring.Models
{
    internal class Notation
    {
        public int NotationId { get; set; }
        public string Name { get; set; }

        public virtual ObservableCollectionListSource<Article> Articles { get; } = new();
    }
}
