using System.ComponentModel.DataAnnotations;

namespace monitoring.Models
{
    internal class Experience
    {
        public int ExperienceId { get; set; }
        [Display(Name = "Стаж")]
        public double Count { get; set; }

        public int ExperienceTypeId { get; set; }
        public int TeacherId { get; set; }
        [Display(Name = "Тип стажа")]
        public virtual ExperienceType ExperienceType { get; set; } = null!;
        [Display(Name = "Преподаватель")]
        public virtual Teacher Teacher { get; set; } = null!;
    }
}
