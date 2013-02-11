using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace darkfallmakro
{
    class Player
    { //0 low 255 high
        Skill firstInQueue = null; 
        Skill[] skill = new Skill[5];
        Boolean[] onCD = new Boolean[5];
        public Player()
        {
            skill[0] = new Skill(this, "blub", 1000, 1000,0);
            skill[1] = new Skill(this, "blub", 2000, 1000,1);
            skill[2] = new Skill(this, "blub", 3000, 1000,2);
            skill[3] = new Skill(this, "blub", 4000, 1000,3);
            skill[4] = new Skill(this, "blub", 5000, 1000,4);
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
    }
}
