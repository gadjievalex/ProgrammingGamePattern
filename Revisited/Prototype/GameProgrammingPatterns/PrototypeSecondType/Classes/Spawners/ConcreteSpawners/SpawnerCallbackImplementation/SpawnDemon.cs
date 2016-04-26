using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeSecondType.Classes.AbstractCharacters;

namespace PrototypeSecondType.Classes.Spawners.ConcreteSpawners.SpawnerCallbackImplementation
{
    public class SpawnDemon:SpawnCallback
    {
        public override Monster SpawnMonster()
        {
            return new Monster(22, 44);
        }
    }
}
