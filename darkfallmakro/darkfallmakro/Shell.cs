using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace darkfallmakro
{
    class Shell
    {
        static void Main(string[] args)
        {
            SimulateKeytest();
        }

        private static void SimulateKeytest()
        {
            System.Threading.Thread.Sleep(3000);
            Control ctrl = new Control();
            Console.WriteLine("Simulating E");
            ctrl.test();
            Console.ReadLine();
        }
    }
}
