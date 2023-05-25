using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassShowcasing
{
    internal class Phone: Electronic
    {
        string battery = " ";

        public string Battery
        {
            get { return battery; }
            set { battery = value; }
        }
        public void Phone1()//vvv
        {
            Console.WriteLine("The phone has buttons, has bluetooth and a battery."); 
        }
        public void Phone2()//xvv
        {
            Console.WriteLine("The phone doesnt have buttons, but has bluetooth and a battery.");
        }
        public void Phone3()//vxv
        {
            Console.WriteLine("The phone has buttons, doesnt have bluetooth but has a battery.");
        }
        public void Phone4()//vvx
        {
            Console.WriteLine("The phone has buttons, has bluetooth but doesnt have a battery.");
        }
        public void Phone5()//xvx
        {
            Console.WriteLine("The phone doesnt have buttons, but has bluetooth and doesnt have a battery.");
        }
        public void Phone6()//vxx
        {
            Console.WriteLine("The phone has buttons, but doesnt have bluetooth and a battery.");
        }
        public void Phone7()//xxv
        {
            Console.WriteLine("The phone doesnt have buttons and bluetooth, but has a battery.");
        }
        public void Phone8()//xxx
        {
            Console.WriteLine("The phone doesnt have buttons, bluetooth and a battery.");
        }
        
    }
}
