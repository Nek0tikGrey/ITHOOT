using Model.Core;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ClientModel:BaseModel
    {
        [Display(Name="Ім'я")]
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Прізвище")]
        [StringLength(50)]
        [Required]
        public string Surname { get; set; }
        [Required]
        public ushort Age { get; set; }
    }
}
