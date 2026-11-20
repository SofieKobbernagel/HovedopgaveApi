using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RestBlaaBogLib
{
    public class Name
    {
        [Key]
        [ForeignKey(nameof(Skole))]
        public int ID { get; set; }

        [Column("schoolName")]
        public string SchoolName { get; set; }

        [JsonIgnore]
        public School Skole { get; set; }
    }
}