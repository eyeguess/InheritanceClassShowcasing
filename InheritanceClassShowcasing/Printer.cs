using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassShowcasing
{
    internal class Printer: Electronic
    {
        string ink = " ";

        public string Ink
        {
            get { return ink; }
            set { ink = value; }
        }

        public void Printer1()//vvv
        {
            Console.WriteLine("The printer has buttons, has bluetooth and ink.");
        }
        public void Printer2()//xvv
        {
            Console.WriteLine("The printer doesnt have buttons, but has bluetooth and ink.");
        }
        public void Printer3()//vxv
        {
            Console.WriteLine("The printer has buttons, doesnt have bluetooth but has ink.");
        }
        public void Printer4()//vvx
        {
            Console.WriteLine("The printer has buttons, has bluetooth but doesnt have ink.");
        }
        public void Printer5()//xvx
        {
            Console.WriteLine("The printer doesnt have buttons, but has bluetooth and doesnt have ink.");
        }
        public void Printer6()//vxx
        {
            Console.WriteLine("The printer has buttons, but doesnt have bluetooth and ink.");
        }
        public void Printer7()//xxv
        {
            Console.WriteLine("The printer doesnt have buttons and bluetooth, but has ink.");
        }
        public void Printer8()//xxx
        {
            Console.WriteLine("The printer doesnt have buttons, bluetooth and ink.");
        }
    }
}
