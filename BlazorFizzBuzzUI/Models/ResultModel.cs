using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFizzBuzzUI.Models
{
    public class ResultModel
    {
        public int Number { get; set; }
        public int Fizz { get; set; }
        public int Buzz { get; set; }
        public string Result => result();

        private string result()
        {
            string res = "";
            if (Fizz == 0)
            {
                res = "Fizz";
            }
            if (Buzz == 0)
            {
                res += "Buzz";
            }
            if (Fizz != 0 && Buzz != 0)
            {
                res = Number.ToString();
            }

            return res;
        }
    }
}
