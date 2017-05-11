using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ECommerce.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "O campo {0} é origatório")]
        [MaxLength(50, ErrorMessage = "O campo {0} deverá ter no máximo {1} caracteres")]
        [Display(Name = "City")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é origatório")]
        [Range(1, double.MaxValue, ErrorMessage ="You must select a {0}")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Company> Companies { get; set; }

        
    }
}