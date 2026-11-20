using RestBlaaBogLib;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace RestBlaaBogLib
{
    public class Secretary
    {
        [Key]
        [Column("Id")]
        [Required]
        public int ID { get; set; }

        [Column("name")]
        [Required] 
        public string Name { get; set; } = string.Empty;

        [Column("role")]
        [Required]
        public string Role { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("profilePicture")]
        public string? ProfilePic { get; set; }

        public Secretary() {}

        public Secretary(int id, string name, string role, string phone, string email, string description, string pic)
        {
            ID = id;
            Name = name;
            Role = role;
            Phone = phone;
            Email = email;
            Description = description;
            ProfilePic = pic;
        }
    }
}