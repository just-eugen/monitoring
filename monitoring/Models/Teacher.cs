using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace monitoring.Models
{
    internal class Teacher
    {
        public int TeacherId { get; set; }
        [Display(Name = "ФИО")]
        public string Name { get; set; }
        [Display(Name = "Объем учебной нагрузки")]
        public string StudyLoad { get; set; }
        [Display(Name = "Ставка")]
        public double Rate { get; set; }

        public int CathedraId { get; set; }
        public int PositionId { get; set; }
        [Display(Name = "Кафедра")]
        public virtual Cathedra Cathedra { get; set; } = null!;
        [Display(Name = "Должность")]
        public virtual Position Position { get; set; } = null!;

        public virtual ObservableCollectionListSource<Experience> Experiences { get; } = new();
        public virtual ObservableCollectionListSource<ContestRequest> ContestRequests { get; } = new();
        public virtual ObservableCollectionListSource<ArticleAuthor> ArticleAuthors { get; } = new();
        public virtual ObservableCollectionListSource<StudyBookAuthor> StudyBookAuthors { get; } = new();
    }
}
