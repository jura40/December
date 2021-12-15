using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace December.Models
{
    public class Employe
    {
        [Key]
        public int EmployeId { get; set; }
        [Column (TypeName ="nvarchar(30)")]
        [Required]
        public string Namn { get; set; }
        [Column(TypeName ="nvarchar(10)")]
        public string Avd { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Position { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Stad { get; set; }
        

    }
}
