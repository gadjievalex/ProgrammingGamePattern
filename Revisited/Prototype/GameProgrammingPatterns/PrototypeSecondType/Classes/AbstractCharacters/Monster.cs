using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSecondType.Classes.AbstractCharacters
{
    public class Monster
    {
        public Monster(int health, int speed)
        {
            Health = health;
            Speed = speed;
            Console.WriteLine(string.Format("{0} is {1}",this,"ParentClass"));
        }

        public int Speed { get; protected set; }
        public int Health { get; protected set; }
        public virtual Monster Clone() { return null; }
    }
}
