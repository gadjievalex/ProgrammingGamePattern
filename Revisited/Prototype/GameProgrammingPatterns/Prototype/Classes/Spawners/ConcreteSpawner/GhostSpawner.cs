using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Classes.AbstractCharacters;
using Prototype.Classes.ConcreteCharacters;

namespace Prototype.Classes.Spawners.ConcreteSpawner
{
    public class GhostSpawner:AbstractSpawner.AbstractSpawner
    {
        public override Monster SpawnMonster()
        {
            return new Ghost();
        }
    }
}
