using Prototype.Classes.AbstractCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Classes.Spawners.AbstractSpawner
{
    public class AbstractSpawner
    {
        public AbstractSpawner() { }
        public virtual Monster SpawnMonster() { return null; }
    }
}
