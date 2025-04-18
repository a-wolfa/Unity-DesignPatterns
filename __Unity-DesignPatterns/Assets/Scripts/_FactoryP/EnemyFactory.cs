using Behaviours;
using UnityEngine;

namespace _FactoryP
{
    public class EnemyFactory
    {
        public Enemy Create(string name,Transform parent, Vector2 position)
        {
            var enemyPrefab = Resources.Load<Enemy>("Enemy");
            var enemy = Object.Instantiate(enemyPrefab, parent, true);

            enemy.transform.name = name;
            enemy.transform.position = position;

            return enemy;
        }
    }
}
