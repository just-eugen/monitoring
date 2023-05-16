namespace monitoring.Models
{
    internal class StudyBookAuthor
    {
        public int StudyBookAuthorId { get; set; }
        public int StudyBookId { get; set; }
        public int TeacherId { get; set; }

        public virtual StudyBook StudyBook { get; set; } = null!;
        public virtual Teacher Teacher { get; set; } = null!;
    }
}
