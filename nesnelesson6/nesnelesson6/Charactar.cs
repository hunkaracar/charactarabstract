using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesnelesson6
{
    public abstract class Charactar
    {
        public abstract string Name { get; set; }
        public abstract int Health { get; set; }
        public abstract int Stamina { get; set; }
        public abstract int Damage { get; set; }

        public abstract void Attack(int eneymHealth);
        public abstract void Wait();

    }
}
