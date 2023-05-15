using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace monitoring.Models
{
    internal class StudyBookType
    {
        public int StudyBookTypeId { get; set; }
        public string Name { get; set; }

        public virtual ObservableCollectionListSource<StudyBook> StudyBooks { get; } = new();
    }
}
