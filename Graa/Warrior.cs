using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graa
{
    internal class Warrior
    {
        private String name;
        private int hp;
        private int dam;
        public Warrior(String name, int hp, int dam)
        {
            this.name = name;
            this.hp = hp;
            this.dam = dam;
        }
        public String getName()
        {
            return name;
        }
        public int getHp() {
            return hp;
        } 
    public int getDam()
        {
            return dam;
        }
    public void takeDam(int dam) {
            hp = hp - dam;
        if (hp < 0)
            {
                hp = 0;
            }
        
        }
    
    
    }
}
