using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace darkfallmakro
{
    class Skill
    {
        private Player player;
        private String name;
        private int coolDown;
        private int castTime; 
        private Timer cd;
        private int priority;
        private Skill previousSkill = null;
        private Skill nextSkill = null;

        public Skill(Player player, String name, int coolDown, int castTime, int priority)
        {
            this.player = player;
            this.name = name;
            this.castTime = castTime;
            this.coolDown = coolDown;
            this.priority = priority;
            this.cd = new Timer(this.coolDown + this.castTime);
            this.cd.Elapsed += new ElapsedEventHandler(resetCD);
            this.cd.AutoReset = false;
        }

        public int getPriority()
        {
            return priority;
        }

        public void enqueue(Skill skill)
        {
            if (nextSkill == null)
            {
                nextSkill = skill;
                skill.setPreviousSkill(this);
            }
            else
            {
                if (nextSkill.getPriority() < skill.getPriority())
                {
                    nextSkill.setPreviousSkill(skill);
                    skill.setNextSkill(nextSkill);                    
                    nextSkill = skill;
                    nextSkill.setPreviousSkill(this);
                }
                else
                {
                    nextSkill.enqueue(skill);
                }
            }
        }

        public void setPreviousSkill(Skill skill)
        {
            previousSkill = skill;
        }

        public Skill getPreviousSkill()
        {
            return previousSkill;
        }

        public void setNextSkill(Skill skill)
        {
            nextSkill = skill;
        }

        public Skill getNextSkill()
        {
            return nextSkill;
        }

        public void castSpell()
        {
            //player.setCD(this);
            this.cd.Start();
        }

        private void resetCD(object source, ElapsedEventArgs e)
        {
            //IS READY
            Console.WriteLine("Hello World!");
        }        
    }
}
