using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class AdditionData
    {
        [Required]
        [Range(0, 100)]
        [Display(Name = "První číslo")]
        public int A { get; set; }
        [Required]
        public int B { get; set; }

        public int Result { get; set; } = 0;
        public int LastA { get; set; }
    }
}
