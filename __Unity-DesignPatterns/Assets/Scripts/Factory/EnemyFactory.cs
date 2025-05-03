using Factory.Enemies.Enums;
using Factory.Enemy.Abstraction;
using UnityEngine;

namespace Factory
{
    public class EnemyFactory : MonoBehaviour
    {
        public GameObject meleePrefab;
        public GameObject rangedPrefab;
        public GameObject bossPrefab;

        public BaseEnemy CreateEnemy(EnemyType type, Vector3 position)
        {
            GameObject prefab = null;

            switch (type)
            {
                case EnemyType.Melee:
                    prefab = meleePrefab;
                    break;
                case EnemyType.Ranged:
                    prefab = rangedPrefab;
                    break;
                case EnemyType.Boss:
                    prefab = bossPrefab;
                    break;
            }

            if (prefab != null)
            {
                GameObject enemyObj = Instantiate(prefab, position, Quaternion.identity);
                return enemyObj.GetComponent<BaseEnemy>();
            }
            
            return null;
        }
    }
}
