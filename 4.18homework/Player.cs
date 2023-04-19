using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._18homework
{
    class Player
    {
        public string name;
        public int hp;
        public int atk;

        
        public Player(string name, int hp, int atk)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;

        }

        public  string Attack()
        {
            return this.name + "は攻撃したが、";
        }

        public string Defence()
        {
            return this.name + "は防御したが、";
        }
    }

}
