using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoHub.Models
{
    [Table(nameof(User))]
    public class User : IdentityUser
    {//id, name, password, email, phone, typeId 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
        public string? Name { get; set; }

        [ForeignKey("UserTypeId")]
        public UserType? UserType { get; set; }
    }
}
