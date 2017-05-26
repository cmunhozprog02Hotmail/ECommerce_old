using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "O campo {0} é origatório")]
        [MaxLength(50, ErrorMessage = "O campo {0} deverá ter no máximo {1} caracteres")]
        [Display(Name = "Company")]
        [Index("Company_Name_Index", IsUnique = true)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é origatório")]
        [MaxLength(20, ErrorMessage = "O campo {0} deverá ter no máximo {1} caracteres")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "O campo {0} é origatório")]
        [MaxLength(100, ErrorMessage = "O campo {0} deverá ter no máximo {1} caracteres")]
        [DataType(DataType.PhoneNumber)]
        public string Address { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [Required(ErrorMessage = "O campo {0} é origatório")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "O campo {0} é origatório")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]
        [Display(Name = "City")]
        public int CityId { get; set; }

        [NotMapped]
        public HttpPostedFileBase LogoFile { get; set; }

        public virtual Department Department { get; set; }

        public virtual City City { get; set; }
    }
}
