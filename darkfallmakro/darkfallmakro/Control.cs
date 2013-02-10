using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace darkfallmakro
{

    class Control
    {
        [DllImport("user32.dll")]
        static extern UInt32 SendInput(UInt32 nInputs, [MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] INPUT[] pInputs, Int32 cbSize);
        public void KeyPress()
        {
            
        }
    }
}
