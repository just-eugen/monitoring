using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace monitoring.Models
{
    internal class StudyBook
    {
        public int StudyBookId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string OutData { get; set; }
        public string ISBN { get; set; }
        public string? Griffin { get; set; }
        public float? Count { get; set; }
        public int? Edition { get; set; }

        public int? EditionTypeId { get; set; }
        public virtual EditionType EditionType { get; set; } = null!;

        public int StudyBookTypeId { get; set; }
        public virtual StudyBookType StudyBookType { get; set; } = null!;

        public virtual ObservableCollectionListSource<StudyBookAuthor> StudyBookAuthors { get; } = new();
    }
}
