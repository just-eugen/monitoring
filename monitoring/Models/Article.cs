using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace monitoring.Models
{
    internal class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string OutData { get; set; }
        public bool? IsPublishedInVak { get; set; }
        public bool? IsPublishedInEng { get; set; }
        public float? Count { get; set; }
        public int? Edition { get; set; }
        public float? ImpactFactor { get; set; }

        public int EditionTypeId { get; set; }
        public virtual EditionType EditionType { get; set; } = null!;

        public int NotationId { get; set; }
        public virtual Notation Notation { get; set; } = null!;

        public int ArticleTypeId { get; set; }
        public virtual ArticleType ArticleType { get; set; } = null!;

        public virtual ObservableCollectionListSource<ArticleAuthor> ArticleAuthors { get; } = new();
    }
}
