using Prototype.Classes.AbstractCharacters;
using Prototype.Classes.ConcreteCharacters;
using Prototype.Classes.Spawners.AbstractSpawner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster ghostPrototype = new Ghost(11, 22);
            AbstractSpawner spawner = new AbstractSpawner(ghostPrototype);

            Monster demonPrototype = new Demon(22, 44);
            spawner = new AbstractSpawner(demonPrototype);

            Monster sorcererPrototype = new Sorcerer(44, 88);
            spawner = new AbstractSpawner(sorcererPrototype);

            Console.ReadLine();
        }
    }
}
