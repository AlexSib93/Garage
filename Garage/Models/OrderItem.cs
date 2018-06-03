using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Garage.Models
{
    [Table("OrderItem", Schema = "Garage")]
    public class OrderItem : AuditClass
    {
        public string Name { get; set; }


        [Required]
        public int IdOrder { get; set; }

        //[ForeignKey("IdOrder")]
        public Order Order { get; set; }
    }
}