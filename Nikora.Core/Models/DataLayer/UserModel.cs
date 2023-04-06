using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nikora.Core.Models.DataLayer
{
    public class UserModel
    {

        [Key]
        [Column("Id")]
        [DisplayName("User Id")]
        public int Id { get; set; }


        [DisplayName("User UserName")]
        [Column("UserName")]
        [Required(ErrorMessage = "UserName is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "UserName must be between 3 and 50 symbols")]
        public string UserName { get; set; }


        [DisplayName("User Password")]
        [Column("Password")]
        [Required(ErrorMessage = "Password is Required")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 50 symbols")]
        public string Password { get; set; }
    }
}
