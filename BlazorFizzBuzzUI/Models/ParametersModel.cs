using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFizzBuzzUI.Models
{
    public class ParametersModel
    {
        [Required]
        public int Start { get; set; }
        [Required]
        public int End { get; set; }
        [Required]
        public int Fizz { get; set; }
        [Required]
        public int Buzz { get; set; }

    }
}
