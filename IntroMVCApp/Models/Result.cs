using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroMVCApp.Models
{
    public class Result
    {
        //Notice num1 is lowercase, this must match whats in the HTML exactly
        //.Net Looooves properties and has a lot of ways of automatically 
        //filling values into them
        public int num1 { get; set; }
        public int num2 { get; set; }
        public string operation { get; set; }
        public int output { get; set; }
    }
}
