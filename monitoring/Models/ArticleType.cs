using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace monitoring.Models
{
    internal class ArticleType
    {
        public int ArticleTypeId { get; set; }
        public string Name { get; set; }

        public virtual ObservableCollectionListSource<Article> Articles { get; } = new();
    }
}
