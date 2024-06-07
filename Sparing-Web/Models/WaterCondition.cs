using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sparing_Web.Models
{
    [Table("tbl_water_condition")]
    public class WaterCondition
    {
        [Column("pid"), Key()]
        public string? Pid { get; set; }

        [Column("ph")]
        public Double? PH { get; set; }

        [Column("cod")]
        public int? Cod { get; set; }

    }
}
