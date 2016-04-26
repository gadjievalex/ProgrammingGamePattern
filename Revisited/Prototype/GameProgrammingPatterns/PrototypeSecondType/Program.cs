using PrototypeSecondType.Classes.AbstractCharacters;
using PrototypeSecondType.Classes.Spawners.AbstractSpawner;
using PrototypeSecondType.Classes.Spawners.ConcreteSpawners;
using PrototypeSecondType.Classes.Spawners.ConcreteSpawners.SpawnerCallbackImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSecondType
{
    class Program
    {
        private static SpawnCallback callbackSpawner;
        private static AbstractSpawner spawner;
        private static Monster character;

        static void Main(string[] args)
        {
            GenerateGhost(callbackSpawner, spawner, character);
            GenerateDemon(callbackSpawner, spawner, character);
            GenerateSorcerer(callbackSpawner, spawner, character);
            
            Console.ReadLine();
        }

        private static void GenerateSorcerer(SpawnCallback callbackSpawner, AbstractSpawner spawner, Monster character)
        {
            callbackSpawner = new SpawnSorcer();
            spawner = new AbstractSpawner(callbackSpawner);
            character = spawner.SpawnMonster();
        }

        private static void GenerateDemon(SpawnCallback callbackSpawner, AbstractSpawner spawner, Monster character)
        {
            callbackSpawner = new SpawnDemon();
            spawner = new AbstractSpawner(callbackSpawner);
            character = spawner.SpawnMonster();
        }

        private static void GenerateGhost(SpawnCallback callbackSpawner, AbstractSpawner spawner, Monster character)
        {
            callbackSpawner = new SpawnGhost();
            spawner = new AbstractSpawner(callbackSpawner);
            character = spawner.SpawnMonster();
        }
    }
}
