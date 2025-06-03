namespace Decorate.Abstractions.Decoraters
{
    public abstract class WeaponDecorator : IWeapon
    {
        protected IWeapon Weapon;
        
        protected WeaponDecorator(IWeapon weapon)
        {
            Weapon = weapon;
        }
        
        public virtual void Attack()
        {
            Weapon.Attack();
        }

        public virtual int GetDamage()
        {
            return Weapon.GetDamage();
        }
    }
}