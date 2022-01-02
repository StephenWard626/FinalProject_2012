using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_0512.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewID { get; set; }
        [Required]
        [DisplayName("Book Name")]
        public string ReviewBook { get; set; }
        [Required]
        [DisplayName("Review")]
        public string ReviewCont { get; set; }
        [Required]
        [DisplayName("Rating")]
        [Range (0,5)]
        public int Rating { get; set; }
    }
}
