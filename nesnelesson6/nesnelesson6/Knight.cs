using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesnelesson6
{
    public class Knight : Charactar
    {

        private string _name;
        private int _health;
        private int _stamina;
        private int _damage;

        public Knight(string name)
        {
            Name = name;
            Health = 20;
            Stamina = 50;
            Damage = 50; 
        }

        public override string Name { get => _name ; set => _name = value ; }
        public override int Health { get => _health; set => _health = value ; }
        public override int Stamina { get => _stamina; set => _stamina = value; }
        public override int Damage { get => _damage; set => _damage = 10; }

        public override void Attack(int eneymHealth)
        {
            if (_stamina > 10)
            {
                eneymHealth -= _damage;
                
            }
            else
            {
                Console.WriteLine("You are tired...");
                Wait();
            }
        }

        public override void Wait()
        {
            if (Stamina<= 10)
            {
                Stamina += 15;
            }
        }
    }
}
