using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace December.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        public DateTime Datum { get; set; }
        public string CustomerNamn { get; set; }
       
        public int EmployeId { get; set; }
        [ForeignKey("EmployeId")]
        public Employe Employe { get; set; }




    }
}
