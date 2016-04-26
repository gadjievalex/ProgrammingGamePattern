using Prototype.Classes.AbstractCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Classes.ConcreteCharacters
{
    public class Ghost:Monster
    {

        public Ghost(int health, int speed):base(health, speed){}

        public override Monster Clone()
        {
            return new Ghost(Health, Speed);
        }
    }
}
