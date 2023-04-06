using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikora.Core.Models.DataLayer
{
    public class ScaleModel
    {
        [Key]
        [Column("Id")]
        [DisplayName("Scale Id")]
        public int Id { get; set; }


        [DisplayName("ScaleIP address")]
        [Column("ScaleIP")]
        [Required(ErrorMessage = "Scale Ip address is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Scale Ip address must be between 3 and 50 symbols")]
        public string ScaleIP { get; set; }


        [DisplayName("Scale Port")]
        [Column("ScalePort")]
        [Required(ErrorMessage = "Scale Port is Required")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Scale Port must be between 8 and 50 symbols")]
        public string ScalePort { get; set; }

        [DisplayName("Scale Name")]
        [Column("ScaleName")]
        [Required(ErrorMessage = "Scale Name is Required")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Scale Name must be between 8 and 50 symbols")]
        public string ScaleName { get; set; }
    }
}
