using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Garage.Models
{
    [Table("Orders", Schema = "Garage")]
    public class Order
    {
        [Key]
        public Int32 Id { get; set; }

        public DateTime DtCreate { get; set; }

        public string Comment { get; set; }
    }
}