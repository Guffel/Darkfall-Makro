using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace darkfallmakro
{
    class Skill
    {
        private String name;
        private int coolDown;
        private int castTime;
        private Timer t1 = new Timer();
        t1.Interval = 100;
        t1.Tick+=new EventHandler(t1_Tick);
        t1.Start();

        public Skill(String name, int coolDown, int castTime)
        {
            this.name = name;
            this.coolDown = coolDown;
            this.castTime = castTime;
        }
        void t1_Tick(object sender, EventArgs e)
        {
// dieser Code wird ausgeführt, wenn der Timer abgelaufen ist
        }   
    }
}
