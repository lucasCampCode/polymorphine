using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Entity
    {
        private string _name;
        private float _health;
        protected float _damage;

        public Entity()
        {
            _name = "bob";
            _health = 100f;
            _damage = 10f;
        }
        public virtual void Attack(Entity enemy)
        {
            enemy.TakeDamage(_damage);
        }

        public virtual void TakeDamage(float damageVal)
        {
            _health -= damageVal;
            if (isAlive())
            {
                _health = 0;
            }
        }

        private bool isAlive()
        {
            return _health < 0;
        }
    }
}
