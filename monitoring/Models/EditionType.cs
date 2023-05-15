using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace monitoring.Models
{
    internal class EditionType
    {
        public int EditionTypeId { get; set; }
        public string Name { get; set; }

        public virtual ObservableCollectionListSource<Article> Articles { get; } = new();
        public virtual ObservableCollectionListSource<StudyBook> StudyBooks { get; } = new();
    }
}
