using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassShowcasing
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Phone a = new Phone();
            Printer b = new Printer();
            Controller c = new Controller();
            string Y = "Yes";
            string y = "yes";
            string N = "No";
            string n = "no";
            bool s = true, d = true, e = true, f = true;
            Console.WriteLine("Please define what kind of device do you want to choose between the following \n 1. Phone \n 2. Printer \n 3. Controller");

            while (s)
            {
                try
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            while (d)
                            {
                                try
                                {
                                    Console.WriteLine("Does it have buttons? (Yes/No)");
                                    a.Button = Console.ReadLine();
                                    bool b1;
                                    if (b1 = a.Button.Equals(Y) || a.Button.Equals(y))
                                    {
                                        d = false;
                                        while (e)
                                        {
                                            try
                                            {
                                                Console.WriteLine("Does it have bluetooth? (Yes/No)");
                                                a.Bluetooth = Console.ReadLine();
                                                bool b2;
                                                if (b2 = a.Bluetooth.Equals(Y) || a.Bluetooth.Equals(y))
                                                {
                                                    e = false;
                                                    while (f)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Does it have a battery? (Yes/No)");
                                                            a.Battery = Console.ReadLine();
                                                            bool b3;
                                                            if (b3 = a.Battery.Equals(Y) || a.Battery.Equals(y))
                                                            {
                                                                a.Phone1();
                                                                f = false;

                                                            }
                                                            else if (b3 = a.Battery.Equals(N) || a.Battery.Equals(n))
                                                            {
                                                                a.Phone4();
                                                                f = false;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Retry again!");
                                                        }
                                                    }
                                                }
                                                else if (b2 = a.Bluetooth.Equals(N) || a.Bluetooth.Equals(n))
                                                {
                                                    e = false;
                                                    while (f)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Does it have a battery? (Yes/No)");
                                                            a.Battery = Console.ReadLine();
                                                            bool b3;
                                                            if (b3 = a.Battery.Equals(Y) || a.Battery.Equals(y))
                                                            {
                                                                a.Phone3();
                                                                f = false;

                                                            }
                                                            else if (b3 = a.Battery.Equals(N) || a.Battery.Equals(n))
                                                            {
                                                                a.Phone6();
                                                                f = false;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Retry again!");
                                                        }
                                                    }
                                                }
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Retry again!");
                                            }
                                        }

                                    }
                                    else if (b1 = a.Button.Equals(N) || a.Button.Equals(n))
                                    {

                                        d = false;
                                        while (e)
                                        {
                                            try
                                            {
                                                Console.WriteLine("Does it have bluetooth? (Yes/No)");
                                                a.Bluetooth = Console.ReadLine();
                                                bool b2;
                                                if (b2 = a.Bluetooth.Equals(Y) || a.Bluetooth.Equals(y))
                                                {
                                                    e = false;
                                                    while (f)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Does it have a battery? (Yes/No)");
                                                            a.Battery = Console.ReadLine();
                                                            bool b3;
                                                            if (b3 = a.Battery.Equals(Y) || a.Battery.Equals(y))
                                                            {
                                                                a.Phone2();
                                                                f = false;

                                                            }
                                                            else if (b3 = a.Battery.Equals(N) || a.Battery.Equals(n))
                                                            {
                                                                a.Phone5();
                                                                f = false;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Retry again!");
                                                        }
                                                    }
                                                }
                                                else if (b2 = a.Bluetooth.Equals(N) || a.Bluetooth.Equals(n))
                                                {
                                                    e = false;
                                                    while (f)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Does it have a battery? (Yes/No)");
                                                            a.Battery = Console.ReadLine();
                                                            bool b3;
                                                            if (b3 = a.Battery.Equals(Y) || a.Battery.Equals(y))
                                                            {
                                                                a.Phone7();
                                                                f = false;

                                                            }
                                                            else if (b3 = a.Battery.Equals(N) || a.Battery.Equals(n))
                                                            {
                                                                a.Phone8();
                                                                f = false;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Retry again!");
                                                        }
                                                    }
                                                }
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Retry again!");
                                            }
                                        }

                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Retry again!");
                                }
                            }
                            break;
                        case 2:
                            while (d)
                            {
                                try
                                {
                                    Console.WriteLine("Does it have buttons? (Yes/No)");
                                    b.Button = Console.ReadLine();
                                    bool b1;
                                    if (b1 = b.Button.Equals(Y) || b.Button.Equals(y))
                                    {
                                        d = false;
                                        while (e)
                                        {
                                            try
                                            {
                                                Console.WriteLine("Does it have bluetooth? (Yes/No)");
                                                b.Bluetooth = Console.ReadLine();
                                                bool b2;
                                                if (b2 = b.Bluetooth.Equals(Y) || b.Bluetooth.Equals(y))
                                                {
                                                    e = false;
                                                    while (f)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Does it have ink? (Yes/No)");
                                                            b.Ink = Console.ReadLine();
                                                            bool b3;
                                                            if (b3 = b.Ink.Equals(Y) || b.Ink.Equals(y))
                                                            {
                                                                b.Printer1();
                                                                f = false;

                                                            }
                                                            else if (b3 = b.Ink.Equals(N) || b.Ink.Equals(n))
                                                            {
                                                                b.Printer4();
                                                                f = false;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Retry again!");
                                                        }
                                                    }
                                                }
                                                else if (b2 = b.Bluetooth.Equals(N) || b.Bluetooth.Equals(n))
                                                {
                                                    e = false;
                                                    while (f)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Does it have ink? (Yes/No)");
                                                            b.Ink = Console.ReadLine();
                                                            bool b3;
                                                            if (b3 = b.Ink.Equals(Y) || b.Ink.Equals(y))
                                                            {
                                                                b.Printer3();
                                                                f = false;

                                                            }
                                                            else if (b3 = b.Ink.Equals(N) || b.Ink.Equals(n))
                                                            {
                                                                b.Printer6();
                                                                f = false;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Retry again!");
                                                        }
                                                    }
                                                }
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Retry again!");
                                            }
                                        }

                                    }
                                    else if (b1 = b.Button.Equals(N) || b.Button.Equals(n))
                                    {

                                        d = false;
                                        while (e)
                                        {
                                            try
                                            {
                                                Console.WriteLine("Does it have bluetooth? (Yes/No)");
                                                b.Bluetooth = Console.ReadLine();
                                                bool b2;
                                                if (b2 = b.Bluetooth.Equals(Y) || b.Bluetooth.Equals(y))
                                                {
                                                    e = false;
                                                    while (f)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Does it have ink? (Yes/No)");
                                                            b.Ink = Console.ReadLine();
                                                            bool b3;
                                                            if (b3 = b.Ink.Equals(Y) || b.Ink.Equals(y))
                                                            {
                                                                b.Printer2();
                                                                f = false;

                                                            }
                                                            else if (b3 = b.Ink.Equals(N) || b.Ink.Equals(n))
                                                            {
                                                                b.Printer5();
                                                                f = false;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Retry again!");
                                                        }
                                                    }
                                                }
                                                else if (b2 = b.Bluetooth.Equals(N) || b.Bluetooth.Equals(n))
                                                {
                                                    e = false;
                                                    while (f)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Does it have ink? (Yes/No)");
                                                            b.Ink = Console.ReadLine();
                                                            bool b3;
                                                            if (b3 = b.Ink.Equals(Y) || b.Ink.Equals(y))
                                                            {
                                                                b.Printer7();
                                                                f = false;

                                                            }
                                                            else if (b3 = b.Ink.Equals(N) || b.Ink.Equals(n))
                                                            {
                                                                b.Printer8();
                                                                f = false;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Retry again!");
                                                        }
                                                    }
                                                }
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Retry again!");
                                            }
                                        }

                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Retry again!");
                                }
                            }
                            break;
                        case 3:
                            while (d)
                            {
                                try
                                {
                                    Console.WriteLine("Does it have buttons? (Yes/No)");
                                    c.Button = Console.ReadLine();
                                    bool b1;
                                    if (b1 = c.Button.Equals(Y) || c.Button.Equals(y))
                                    {
                                        d = false;
                                        while (e)
                                        {
                                            try
                                            {
                                                Console.WriteLine("Does it have bluetooth? (Yes/No)");
                                                c.Bluetooth = Console.ReadLine();
                                                bool b2;
                                                if (b2 = c.Bluetooth.Equals(Y) || c.Bluetooth.Equals(y))
                                                {
                                                    e = false;
                                                    while (f)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Does it have joysticks? (Yes/No)");
                                                            c.Joystick = Console.ReadLine();
                                                            bool b3;
                                                            if (b3 = c.Joystick.Equals(Y) || c.Joystick.Equals(y))
                                                            {
                                                                c.Controller1();
                                                                f = false;

                                                            }
                                                            else if (b3 = c.Joystick.Equals(N) || c.Joystick.Equals(n))
                                                            {
                                                                c.Controller4();
                                                                f = false;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Retry again!");
                                                        }
                                                    }
                                                }
                                                else if (b2 = c.Bluetooth.Equals(N) || c.Bluetooth.Equals(n))
                                                {
                                                    e = false;
                                                    while (f)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Does it have joysticks? (Yes/No)");
                                                            c.Joystick = Console.ReadLine();
                                                            bool b3;
                                                            if (b3 = c.Joystick.Equals(Y) || c.Joystick.Equals(y))
                                                            {
                                                                c.Controller3();
                                                                f = false;

                                                            }
                                                            else if (b3 = c.Joystick.Equals(N) || c.Joystick.Equals(n))
                                                            {
                                                                c.Controller6();
                                                                f = false;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Retry again!");
                                                        }
                                                    }
                                                }
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Retry again!");
                                            }
                                        }

                                    }
                                    else if (b1 = c.Button.Equals(N) || c.Button.Equals(n))
                                    {

                                        d = false;
                                        while (e)
                                        {
                                            try
                                            {
                                                Console.WriteLine("Does it have bluetooth? (Yes/No)");
                                                c.Bluetooth = Console.ReadLine();
                                                bool b2;
                                                if (b2 = c.Bluetooth.Equals(Y) || c.Bluetooth.Equals(y))
                                                {
                                                    e = false;
                                                    while (f)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Does it have joysticks? (Yes/No)");
                                                            c.Joystick = Console.ReadLine();
                                                            bool b3;
                                                            if (b3 = c.Joystick.Equals(Y) || c.Joystick.Equals(y))
                                                            {
                                                                c.Controller2();
                                                                f = false;

                                                            }
                                                            else if (b3 = c.Joystick.Equals(N) || c.Joystick.Equals(n))
                                                            {
                                                                c.Controller5();
                                                                f = false;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Retry again!");
                                                        }
                                                    }
                                                }
                                                else if (b2 = c.Bluetooth.Equals(N) || c.Bluetooth.Equals(n))
                                                {
                                                    e = false;
                                                    while (f)
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Does it have joysticks? (Yes/No)");
                                                            c.Joystick = Console.ReadLine(); ;
                                                            bool b3;
                                                            if (b3 = c.Joystick.Equals(Y) || c.Joystick.Equals(y))
                                                            {
                                                                c.Controller7();
                                                                f = false;

                                                            }
                                                            else if (b3 = c.Joystick.Equals(N) || c.Joystick.Equals(n))
                                                            {
                                                                c.Controller8();
                                                                f = false;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("Retry again!");
                                                        }
                                                    }
                                                }
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Retry again!");
                                            }
                                        }

                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Retry again!");
                                }
                            }
                            break;
                    }
                    s = false;
                }
                catch
                {
                    Console.WriteLine("Retry again!");
                }
            }

        }
    }
}
