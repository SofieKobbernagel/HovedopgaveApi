using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestBlaaBogLib
{
    [Table("by")]
    public class City
    {
        [Key]
        [ForeignKey(nameof(Skole))]
        public int ID { get; set; }

        [Column("city")]
        [Required]
        public string SchoolCity { get; set; } = string.Empty;

        [JsonIgnore]
        public School Skole { get; set; } = null!;
    }
}
