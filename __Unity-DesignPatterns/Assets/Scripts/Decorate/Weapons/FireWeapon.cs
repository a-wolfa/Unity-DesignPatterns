using Decorate.Abstractions;
using Decorate.Abstractions.Decoraters;
using UnityEngine;

namespace Decorate.Weapons
{
    public class FireWeapon : WeaponDecorator
    {
        public FireWeapon(IWeapon weapon) : base(weapon) {}
        
        public override void Attack()
        {
            base.Attack();
            Debug.Log("Burning the enemy with fire!");
        }
        
        public override int GetDamage()
        {
            return base.GetDamage() + 5;
        }
    }
}