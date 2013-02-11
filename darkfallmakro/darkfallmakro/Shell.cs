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
            //SimulateKeytest();
            test();
        }

        private static void SimulateKeytest()
        {
            System.Threading.Thread.Sleep(3000);
            Control ctrl = new Control();
            Console.WriteLine("Simulating E");
            ctrl.SendKeyDown(Control.KeyCode.KEY_2);
            System.Threading.Thread.Sleep(500);
            ctrl.SendKeyUp(Control.KeyCode.KEY_2);
            System.Threading.Thread.Sleep(500);
            ctrl.test();
            Console.ReadLine(); 
        }
        private static void test()
        {
            Player asd = new Player();
            Console.WriteLine("fertig");
            Console.ReadLine(); 
        }
    }
}
