﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeSecondType.Classes.AbstractCharacters;
using PrototypeSecondType.Classes.ConcreteCharacters;

namespace PrototypeSecondType.Classes.Spawners.ConcreteSpawners.SpawnerCallbackImplementation
{
    public class SpawnSorcer:SpawnCallback
    {
        public override Monster SpawnMonster()
        {
            return new Sorcerer(44, 88);
        }
    }
}
