using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharpFun
{
    internal class PrintStuff
    {
        //constructor
        public PrintStuff(string language) {
            language = temp;
        }
        public string PrintName(string n)
        {
            if (language == "en")
            {
                string output = "";

                output = "Hello " + n + "!";

                return output;
            }
            else
            {
                System.Console.WriteLine("Oi " + n + "!");
            }
           
        }

    }
}
