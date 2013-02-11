using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;


namespace darkfallmakro
{
    class Player
    { //0 low 255 high
        private Skill firstInQueue = null; 
        private Skill[] skill = new Skill[5];
        private int health;
        private int stamina;
        private int mana;
        private Timer nextSkill;
        public Player()
        {
            skill[0] = new Skill(this, "1", 1000, 1000,0);
            skill[1] = new Skill(this, "2", 2000, 1000,1);
            skill[2] = new Skill(this, "3", 3000, 1000,2);
            skill[3] = new Skill(this, "4", 8000, 1000,3);
            skill[4] = new Skill(this, "5", 10000, 1000,4);
        }
        public void enqueue(Skill skill)
        {
            if (firstInQueue==null)
            {
                firstInQueue = skill;
            } else 
            {
                if (firstInQueue.getPriority() < skill.getPriority())
                {
                    firstInQueue.setPreviousSkill(skill);
                    skill.setNextSkill(firstInQueue);                   
                    firstInQueue = skill;
                }
                else
                {
                    firstInQueue.enqueue(skill);
                }
            }
        }

        public void dequeue()
        {
            Skill skill = firstInQueue.getNextSkill();
            firstInQueue.setNextSkill(null);
            firstInQueue = skill;
        }

        public void initCasting()
        {            
            this.nextSkill = new Timer(this.firstInQueue.getCastTime());
            this.nextSkill.Elapsed += new ElapsedEventHandler(useNextSkill);
            this.nextSkill.AutoReset = false;
            this.firstInQueue.castSpell();
            dequeue();
            nextSkill.Start();
        }

        private void useNextSkill(object source, ElapsedEventArgs e)//funkt nicht
        {
            if (this.firstInQueue == null)
            {                
                Console.WriteLine("No Cast");
                nextSkill.Interval = 1000;
                nextSkill.Start();
            }
            else
            {
                nextSkill.Interval = this.firstInQueue.getCastTime();
                this.firstInQueue.castSpell();
                dequeue();
                nextSkill.Start();
            }
        }  
    }
}
