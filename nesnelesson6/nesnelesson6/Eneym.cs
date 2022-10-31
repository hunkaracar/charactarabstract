using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesnelesson6
{
    public class Eneym : Charactar
    {
        private string? _name;
        private int _health;
        private  int _stamina;
        private int _damage;

        public Eneym(string? name) //constructor
        {
            Name = name;
            Health = 20;
            Stamina = 20;  
            Damage = 20;   
        }


        public override string Name { get => _name; set => _name = "eneym"; }
        public override int Health { get => _health ; set => _health = value  ; }
        public override int Stamina { get => _stamina; set => _stamina = value; }
        public override int Damage { get => _damage; set => _damage = 10; }

        public override void Attack(int eneymHealth)
        {
            if(_stamina >= 10)
            {
                eneymHealth -= _damage;
                _stamina -= 10;
            }
            else
            {
                Wait();
            }
        }

        public override void Wait()
        {
            if (_stamina < 10)
            {
                _stamina += 10;
            }
        }
    }
}
