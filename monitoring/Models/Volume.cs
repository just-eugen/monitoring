using System.ComponentModel.DataAnnotations;

namespace monitoring.Models
{
    internal class Volume
    {
        public int VolumeId { get; set; }
        [Display(Name = "Год начала")]
        public int BeginYear { get; set; }
        [Display(Name = "Год окончания")]
        public int EndYear { get; set; }
        [Display(Name = "Коменнтарий")]
        public string? Comment { get; set; }

        public int ContestRequestId { get; set; }
        [Display(Name = "Заявка на конкурс НИР")]
        public virtual ContestRequest ContestRequest { get; set; } = null!;
    }
}
