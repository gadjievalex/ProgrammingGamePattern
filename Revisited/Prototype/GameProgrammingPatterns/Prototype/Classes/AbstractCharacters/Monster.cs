using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Classes.AbstractCharacters
{
    public class Monster
    {
        public Monster()
        {
            Console.WriteLine(string.Format("{0} is {1}",this,"ParentClass"));
        }
    }
}
