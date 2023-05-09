namespace monitoring.Models
{
    internal class Cathedra
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? FullName { get; set; }

        public int UniverId { get; set; }
        public virtual Univer Univer { get; set; } = null!;
    }
}
