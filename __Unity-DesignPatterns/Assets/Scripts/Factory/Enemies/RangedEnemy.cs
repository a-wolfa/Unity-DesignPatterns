using Factory.Enemy.Abstraction;
using UnityEngine;

namespace Factory.Enemies
{
    public class RangedEnemy : BaseEnemy
    {

        public override void Attack()
        {
            Debug.Log("Ranged attack");
        }
    }
}
