using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace FactoryP
{
    public class EnemyFactoryController : MonoBehaviour
    {
        private readonly EnemyFactory _enemyFactory = new EnemyFactory();
    
        [SerializeField] private Transform parent;

        private void Start()
        {
            Generate();
            InvokeRepeating(nameof(Generate), 3f, 10);
        }

        private void Generate()
        {
            var x = Random.Range(-8.0f, 8.0f);
            var y = Random.Range(-4.0f, 4.0f);

            _enemyFactory.Create("Enemy",parent, new Vector2(x, y));
        }
    }
}
