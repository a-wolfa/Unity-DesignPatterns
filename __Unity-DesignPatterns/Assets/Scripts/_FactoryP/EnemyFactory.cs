using UnityEngine;

namespace FactoryP
{
    public class EnemyFactory
    {
        public Enemy.Enemy Create(string name,Transform parent, Vector2 position)
        {
            var enemyPrefab = Resources.Load<Enemy.Enemy>("Enemy");
            var enemy = Object.Instantiate(enemyPrefab, parent, true);

            enemy.transform.name = name;
            enemy.transform.position = position;

            return enemy;
        }
    }
}
