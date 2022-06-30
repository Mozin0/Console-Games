using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public abstract class Entity
    {
        private const int MaxHealth = 100;

        protected Entity(string name)
        {
            Name = name;
        }
        public string Name { get; }

        public int Health { get; protected set; } = MaxHealth;
    }
}

