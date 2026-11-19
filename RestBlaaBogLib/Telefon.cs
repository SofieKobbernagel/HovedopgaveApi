using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RestBlaaBogLib
{
    public class Telefon
    {
        [Key]
        [ForeignKey(nameof(Skole))]
        public int ID { get; set; }

        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonIgnore]
        public School Skole { get; set; }
    }
}