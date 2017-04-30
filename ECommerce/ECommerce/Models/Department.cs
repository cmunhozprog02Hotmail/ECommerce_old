using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage ="O campo {0} é origatório")]
        [MaxLength(50, ErrorMessage ="O campo {0} deverá ter no máximo {1} caracteres")]
        public string Name { get; set; }
    }
}