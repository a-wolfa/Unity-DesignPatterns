using System.Collections;
using System.Collections.Generic;
using BuilderP.Builder;
using UnityEngine;
using Random = UnityEngine.Random;

namespace BuilderP.Controller
{
    public class EnemyGenerateController : MonoBehaviour
    {
        [SerializeField] private Transform parent;
        [SerializeField] private float delay = 4f;

        private void Start()
        {
            Generate();
            InvokeRepeating(nameof(Generate), delay, 10);
        }

        // ReSharper disable Unity.PerformanceAnalysis
        private void Generate()
        {
            var x = Random.Range(-8.0f, 8.0f);
            var y = Random.Range(-4.0f, 4.0f);

            new EnemyBuilder()
                .SetName("Starex")
                .SetPosition(new Vector2(x, y))
                .SetParent(parent)
                .Build();
        }
    }
}