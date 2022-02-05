using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Project.Models
{
    public class Passsenger
    {
        [Key]
        public int PassengerID { get; set; }


        [Required, MaxLength(50)]
        public string PassengerName { get; set; }


        [Required, MaxLength(50)]
        public string PassengerEmail { get; set; }


        [Required, MaxLength(50)]
        public string PassengerPhone { get; set; }


        [Required]
        public DateTime JourneyDate { get; set; }


        [Required]
        public int TrainID { get; set; }

        [Required]
        public int RouteID { get; set; }

        [Required]
        public int ClassID { get; set; }

        [Required]
        public decimal Fee { get; set; }
        public string PhotoPath { get; set; }

        public virtual Train Train { get; set; }
        public virtual Class Class { get; set; }
        public virtual Route Route { get; set; }
    }
}
