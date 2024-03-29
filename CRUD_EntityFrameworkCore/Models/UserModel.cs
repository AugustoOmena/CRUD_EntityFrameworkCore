using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace CRUD_EntityFrameworkCore.Models
{
    public class UserModel
    {
        [Key]
        [Column(TypeName = "int")]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Primeiro Nome")]
        public String FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Ultimo Nome")]
        public String LastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Contact No")]
        public String ContactNo { get; set; } = "0";
    }
}
