using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace monitoring.Models
{
    internal class ContestType
    {
        public int ContestTypeId { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }

        public virtual ObservableCollectionListSource<ContestRequest> ContestRequests { get; set; } = new();
    }
}
