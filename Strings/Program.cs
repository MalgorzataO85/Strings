using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var input = Console.ReadLine();
                var printer = new Print(33);
                Console.WriteLine(printer.MyProperty);
                //var printer = new Print();
                //printer.PrintPdf();
                //printer.PrintTxt();
                Console.WriteLine("roman".Left(2));
                Console.WriteLine("roman".Left());

            //    int x = 23;
            //    bool t = true;
            //    string text = $"Ala ma {x}kota i jeszcze COŚ Tam.{t}";
            //    //Console.WriteLine(text.Substring(0, 3));
            //    StringBuilder sb = new StringBuilder();
            //    sb.Append(text);
            //    Stopwatch stopwatch = new Stopwatch();
            //    stopwatch.Start();
            //    for (int i = 0; i < 10000; i++)
            //    {
            //        //text += i.ToString();
            //        sb.Append(i.ToString());
            //    }
            //    text = sb.ToString();
            //    stopwatch.Stop();
            //    Console.WriteLine(text);
            //    Console.WriteLine(stopwatch.ElapsedMilliseconds);
            //    //text = text.ToLower();
            //    ////text = text.ToUpper();
            //    //text = text.TrimStart(); //usuwa spacje
            //    //text = text.Replace("Ala", "Roman");
            //    //text = text.Remove(10,2); //usuwa od indeksu do końca, po przecinku mozna podać liczbę znaków do usunięia
            //    //text = text + text + 22222222222222;
            //    //text = string.Concat(text, text);

            //    //if ("a" != "b")
            //    //{
            //    //    if( string.Compare("c", "C", false) == 0)
            //    //    {

            //    //    }
            //    //}

            //    //var strinArray = text.Split(' ');
            //    //var x = string.Join(";", strinArray);
            //    //var array = text.ToArray();
            //    //Console.WriteLine(array[1]);

            //    //Console.WriteLine(args[0]);
            //    //Console.WriteLine(args[1]);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            Console.Read();

        }
        static void Print(string firstParam)
        {
            Console.WriteLine(firstParam);
        }
        static void Print(string firstParam, int age = 0) //domyślne parametry moga być tylko na końcu
        {
            Console.WriteLine(firstParam);
            Console.WriteLine(age);
        }
    }
}
