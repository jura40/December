using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace December.Models
{
    public enum CompanyTypes
    { A, B, C }
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string CompanyName { get; set; }
        public CompanyTypes? CompanyTypes { get; set; }
        public virtual ICollection<Employe> Employes { get; set; }
    }
}
