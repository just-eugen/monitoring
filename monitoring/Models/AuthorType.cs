using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace monitoring.Models
{
    internal class AuthorType
    {
        public int AuthorTypeId { get; set; }
        public string Name { get; set; }

        public virtual ObservableCollectionListSource<ArticleAuthor> ArticleAuthors { get; } = new();
    }
}
