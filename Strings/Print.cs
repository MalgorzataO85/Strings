using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Print
    {
        public Print ()  //konstruktorów może być kilka
        {

        }
        public Print (int rr)   //wymagany parametr, inaczej konstruktor nie zadziała
        {
            this.MyProperty = rr;
        }
        public void PrintPdf()
        {
            Console.WriteLine("PDF");
        }
        public int MyProperty { get; set; }
    }
}
