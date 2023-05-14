using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace monitoring.Models
{
    public class Univer
    {
        public int UniverId { get; set; }
        [Display(Name = "Аббревиатура")]
        public string Name { get; set; }
        [Display(Name = "Полное название")]
        public string? FullName{ get; set; }

        public virtual ObservableCollectionListSource<Cathedra> Cathedras { get; } = new();
    }
}
