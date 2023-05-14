using System.ComponentModel.DataAnnotations;

namespace monitoring.Models
{
    public class Cathedra
    {
        public int CathedraId { get; set; }
        [Display(Name = "Аббревиатура")]
        public string Name { get; set; }
        [Display(Name = "Полное название")]
        public string? FullName { get; set; }

        public int UniverId { get; set; }
        [Display(Name = "Университет")]
        public virtual Univer Univer { get; set; } = null!;
    }
}
