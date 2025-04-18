using _BuilderP.Builder;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _BuilderP.Controller
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
        
        private void Generate()
        {
            var x = Random.Range(-8.0f, 8.0f);
            var y = Random.Range(-4.0f, 4.0f);

            new EnemyBuilder()
                .SetPosition(new Vector2(x, y))
                .SetName()
                .SetParent(parent)
                .Build();
        }
    }
}