using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    public interface IDevice
    {
        string Name { get; set; }

        void Connect ();
    }

    public class RealDevice : IDevice
    {
        public string Name { get; set; }

        public void Connect ()
        {
            Console.WriteLine("Device is connecting...");
        }
    }

    public class NullDevice : IDevice
    {
        public string Name
        {
            // Return something making it obvious this is the null object.
            get { return "null device"; }

            set { /* do nothing */ }
        }

        public void Connect ()
        {
            // Normally the method in the null object will just do nothing.
            Console.WriteLine("Device is null so do nothing");
        }
    }
}
