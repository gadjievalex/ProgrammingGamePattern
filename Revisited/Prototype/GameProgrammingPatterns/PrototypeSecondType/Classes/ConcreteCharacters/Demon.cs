using PrototypeSecondType.Classes.AbstractCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSecondType.Classes.ConcreteCharacters
{
    public class Demon:Monster
    {
        public Demon(int healt, int speed):base(healt, speed){}

        public override Monster Clone()
        {
            return new Demon(Health, Speed);
        }
    }
}
