using PrototypeSecondType.Classes.AbstractCharacters;
using PrototypeSecondType.Classes.Spawners.ConcreteSpawners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSecondType.Classes.Spawners.AbstractSpawner
{
    public class AbstractSpawner
    {
        public AbstractSpawner(SpawnCallback spawn)
        {
            this.callBackSpawner = spawn;
        }
        
        public virtual Monster SpawnMonster() { return callBackSpawner.SpawnMonster(); }

        private Monster prototype;
        private SpawnCallback callBackSpawner;
    }
}
