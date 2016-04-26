using PrototypeSecondType.Classes.AbstractCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSecondType.Classes.Spawners.ConcreteSpawners
{
    public class SpawnCallback
    {
        public virtual Monster SpawnMonster() { return null; }
    }
}
