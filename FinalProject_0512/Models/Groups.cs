using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_0512.Models
{
    public class Groups
    {
        [Key]
        public int GroupID { get; set; }
        [Required]
        [DisplayName("Group Name")]
        public string GroupName { get; set; }
        [Required]
        [DisplayName("Group Genre")]
        public string GroupGenre { get; set; }
        [Required]
        [DisplayName("Book Series")]
        public string GroupSeries { get; set; }
        [DisplayName("No. of Members")]
        public int MemberCount { get; set; }
    }
}
