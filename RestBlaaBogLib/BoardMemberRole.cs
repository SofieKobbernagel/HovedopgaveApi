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
    [Table("BoardMemberRole")]
    public class BoardMemberRole
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("roleName")]
        [Required]
        public string RoleName { get; set; } = string.Empty;

        [JsonIgnore]
        public BoardMember BoardMember { get; set; }
    }
}
