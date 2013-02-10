using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System

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
            ctrl.KeyPress();
            Console.ReadLine();
        }
    }
}
