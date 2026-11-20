using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RestBlaaBogLib
{
    public class Email
    {
        [Key]
        [ForeignKey(nameof(Skole))]
        public int ID { get; set; }

        [Column("emailAddress")]
        [Required]
        public string EmailAddress { get; set; } = string.Empty;

        [JsonIgnore]
        public School Skole { get; set; } = null!;
    }
}