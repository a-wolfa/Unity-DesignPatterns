using Decorate.Abstractions;
using UnityEngine;

namespace Decorate.Weapons
{
    public class Sword : IWeapon
    {
        public void Attack()
        {
            Debug.Log("Sword Attack");
        }

        public int GetDamage()
        {
            return 10;
        }
    }
}