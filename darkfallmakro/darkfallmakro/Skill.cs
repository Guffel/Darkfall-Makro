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
        private Boolean onCD = false;
        private int castTime;
        private Timer cd;

        public Skill(String name, int coolDown, int castTime)
        {
            this.name = name;
            this.castTime = castTime;
            this.cd = new Timer(coolDown); // in ms            
            this.cd.Elapsed += new ElapsedEventHandler(resetCD);
            this.cd.Enabled = true;
        }

        public void castSpell()
        {
            this.cd.Enabled = true;
        }

        private void resetCD(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }   
    }
}
