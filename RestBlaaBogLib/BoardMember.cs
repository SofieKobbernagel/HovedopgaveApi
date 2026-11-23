using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestBlaaBogLib
{
    public class BoardMember
    {
        [Key]
        [Column("Id")]
        [Required]
        public int ID { get; set; }

        [Column("name")]
        [Required]
        public string Name { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("phoneNumber")]
        public string? PhoneNumber { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("imageUrl")]
        public string? ImageUrl { get; set; }

        [Column("roleId")]
        public int RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public BoardMemberRole Role { get; set; } = null!;

        public BoardMember() { }

        public BoardMember(int id, string name, string? email, string? phone, string? descr, string image)
        {
            ID = id;
            Name = name;
            Email = email;
            PhoneNumber = phone;
            Description = descr;
            ImageUrl = image;
        }
    }
}
