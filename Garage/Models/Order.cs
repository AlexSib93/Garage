using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Garage.Models
{
    [Table("Orders", Schema = "Garage")]
    public class Order : AuditClass
    {
        public string Name { get; set; }

        public DateTime? PlanDate { get; set; }

        public string Comment { get; set; }

        [ForeignKey("IdOrder")]
        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
    }
}