using PrototypeSecondType.Classes.AbstractCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSecondType.Classes.ConcreteCharacters
{
    public class Sorcerer : Monster
    {
        public Sorcerer(int health, int speed) : base(health, speed){}
    }
}
