using UnityEngine;

namespace BuilderP.Builder
{
    public class EnemyBuilder
    {
        private readonly Enemy.Enemy _enemy;

        public EnemyBuilder()
        {
            var enemyPrefab = Resources.Load<Enemy.Enemy>("Enemy");
            _enemy = Object.Instantiate(enemyPrefab);
        }

        public EnemyBuilder SetName(string objectName)
        {
            _enemy.transform.name = objectName;
            return this;
        }

        public EnemyBuilder SetPosition(Vector3 position)
        {
            _enemy.transform.position = position;
            return this;
        }

        public EnemyBuilder SetParent(Transform parent)
        {
            _enemy.transform.parent = parent;
            return this;
        }

        public Enemy.Enemy Build()
        {
            return _enemy;
        }
    }
}