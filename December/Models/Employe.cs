using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Required (ErrorMessage ="Den måste infylas")]
        [DisplayName ("Full Namn")]

        public string Namn { get; set; }
        [Column(TypeName ="nvarchar(10)")]
        [DisplayName("Avdelning")]
        public string Avd { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Position { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [DisplayName("Stad")]
        public string Stad { get; set; }
        

    }
}
