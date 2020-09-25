using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Wizard : Entity
    {
        private float _mana;

        public override void Attack(Entity enemy)
        {   
            float totalDamage = _damage;
            if(_mana >= 4)
            {
                totalDamage += _mana * 0.25f;
                _mana -= _mana * 0.25f;
                enemy.TakeDamage(totalDamage);
            }
            else
            {
                base.Attack(enemy);
            }
        }
    }
}
