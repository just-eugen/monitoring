using System.ComponentModel.DataAnnotations;

namespace monitoring.Models
{
    internal class ContestRequest
    {
        public int ContestRequestId { get; set; }
        [Display(Name = "Тема")]
        public string Name { get; set; }
        [Display(Name = "Стоимость проекта")]
        public float ProjectCost { get; set; }
        [Display(Name = "Заявка одобрена")]
        public bool ProjectApproval { get; set; }

        public int TeacherId { get; set; }
        public int ContestTypeId { get; set; }
        [Display(Name = "Преподаватель")]
        public virtual Teacher Teacher { get; set; } = null!;
        [Display(Name = "Тип заявки")]
        public virtual ContestType ContestType { get; set; } = null!;

        public virtual Volume Volume { get; set; } = new();
    }
}
