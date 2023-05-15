using monitoring.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace monitoring.Models
{
    internal class ArticleAuthor
    {
        public int ArticleId { get; set; }
        public int TeacherId { get; set; }
        public int AuthorTypeId { get; set; }

        public virtual AuthorType AuthorType { get; set; } = null!;
        public virtual Article Article { get; set; } = null!;
        public virtual Teacher Teacher { get; set; } = null!;

    }
}
