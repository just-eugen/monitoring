using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace monitoring.Models
{
    internal class ExperienceType
    {
        public int ExperienceTypeId { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }

        public ObservableCollectionListSource<Experience>? Experiences { get; set; } = new();
    }
}
