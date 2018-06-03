using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage.Models
{
    public class AuditClass
    {
        [Key]
        public int Id { get; set; }

        public DateTime? DtCreate { get; set; }

        public DateTime? DtEdit { get; set; }

        public string PeopleEdit { get; set; }

        public string PeopleCreate { get; set; }
    }
}