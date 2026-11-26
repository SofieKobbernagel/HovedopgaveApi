using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RestBlaaBogLib
{
    public class Images
    {
        [Key]
        [ForeignKey(nameof(Skole))]
        public int ID { get; set; }

        [Column("ImageUrl")]
        public byte[] ImageUrl { get; set; }

        [JsonIgnore]
        public School Skole { get; set; }
    }
}