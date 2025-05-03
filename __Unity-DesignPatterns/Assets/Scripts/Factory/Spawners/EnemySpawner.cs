using System;
using Factory.Enemies.Enums;
using Factory.Enemy.Abstraction;
using UnityEngine;

namespace Factory.Spawners
{
    public class EnemySpawner : MonoBehaviour
    {
        public EnemyFactory factory;

        private void Start()
        {
            BaseEnemy enemy1 = factory.CreateEnemy(EnemyType.Melee, new Vector3(0, 0, 0));
            enemy1.Attack();
            
            BaseEnemy enemy2 = factory.CreateEnemy(EnemyType.Boss, new Vector3(5, 0, 0));
            enemy2.Attack();
        }
    }
}
