using Decorate.Abstractions;
using Decorate.Abstractions.Decoraters;

namespace Decorate.Weapons
{
    public class IceWeapon : WeaponDecorator
    {
        public IceWeapon(IWeapon weapon) : base(weapon) {}
        
        public override void Attack()
        {
            base.Attack();
            UnityEngine.Debug.Log("Freezing the enemy with ice!");
        }

        public override int GetDamage()
        {
            return base.GetDamage() + 3;
        }
    }
}