using PrototypeSecondType.Classes.AbstractCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSecondType.Classes.Spawners.AbstractSpawner
{
    public class AbstractSpawner
    {
        public AbstractSpawner(Monster prototype)
        {
            this.prototype = prototype;
        }
        
        public virtual Monster SpawnMonster() { return prototype.Clone(); }

        private Monster prototype;
    }
}
