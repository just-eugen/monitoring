using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace monitoring.Models
{
    internal class Position
    {
        public int PositionId { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }

        public virtual ObservableCollectionListSource<Teacher> Teachers { get; set; } = new();
    }
}
