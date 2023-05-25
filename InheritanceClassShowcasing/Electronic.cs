using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassShowcasing
{
    public abstract class Electronic
    {
        string button = "", bluetooth = "" ;

        public string Button
        {
            get { return button; }
            set { button = value; }
        }

        public string Bluetooth
        {
            get { return bluetooth; }
            set { bluetooth = value; }
        }
    }
}
