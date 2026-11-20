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
    [Table("Work")]
    public class SecretaryRole
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Name")]
        [Required]
        public string RoleName { get; set; } = string.Empty;

        [JsonIgnore]
        public Secretary Secretary { get; set; }
    }
}
