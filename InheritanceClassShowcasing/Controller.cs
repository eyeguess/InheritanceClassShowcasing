using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassShowcasing
{
    internal class Controller: Electronic
    {
        string joystick = " ";

        public string Joystick
        {
            get { return joystick; }
            set { joystick = value; }
        }

        public void Controller1()//vvv
        {
            Console.WriteLine("The controller has buttons, has bluetooth and joysticks.");
        }
        public void Controller2()//xvv
        {
            Console.WriteLine("The controller doesnt have buttons, but has bluetooth and joysticks.");
        }
        public void Controller3()//vxv
        {
            Console.WriteLine("The controller has buttons, doesnt have bluetooth but has joysticks.");
        }
        public void Controller4()//vvx
        {
            Console.WriteLine("The controller has buttons, has bluetooth but doesnt have joysticks.");
        }
        public void Controller5()//xvx
        {
            Console.WriteLine("The controller doesnt have buttons, but has bluetooth and doesnt have joysticks.");
        }
        public void Controller6()//vxx
        {
            Console.WriteLine("The controller has buttons, but doesnt have bluetooth and joysticks.");
        }
        public void Controller7()//xxv
        {
            Console.WriteLine("The controller doesnt have buttons and bluetooth, but has joysticks.");
        }
        public void Controller8()//xxx
        {
            Console.WriteLine("The controller doesnt have buttons, bluetooth and joysticks.");
        }
    }
}
