using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffer.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("ERROR: Too few arguments given.");
                Console.WriteLine("Usage: buffer.cs <duration> <# of producers> <# of consumers>");
                return;
            }

            Console.WriteLine("Hello, you entered {0}, then {1}, then {2}.", args[0], args[1], args[2]);

            CircularBuffer<int> buffer = new CircularBuffer<int>();
            Console.WriteLine("Buffer size: {0}", buffer.Size);

            Console.WriteLine("Adding {0}", args[0]);
            buffer.add(Int32.Parse(args[0]));

            Console.WriteLine("Removed {0}", buffer.remove());
        }
    }
}