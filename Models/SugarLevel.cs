using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SugarLevelTracker.Models
{
    public class SugarLevel
    {
        [Key]
        public int id { get; set;}

        [Required]
        public float Value { get; set; }
        
        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime MeasuredAt { get; set; }
    }
}