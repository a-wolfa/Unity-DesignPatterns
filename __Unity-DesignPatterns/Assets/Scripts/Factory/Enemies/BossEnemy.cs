using Factory.Enemy.Abstraction;
using UnityEngine;

namespace Factory.Enemies
{
    public class BossEnemy : BaseEnemy
    {
        public override void Attack()
        {
            Debug.Log("Boss attack");
        }
    }
}
