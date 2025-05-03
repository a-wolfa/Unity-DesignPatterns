using Factory.Enemy.Abstraction;
using UnityEngine;

namespace Factory.Enemies
{
    public class MeleeEnemy : BaseEnemy
    {
        public override void Attack()
        {
            Debug.Log("Melee attack");
        }
    }
}
