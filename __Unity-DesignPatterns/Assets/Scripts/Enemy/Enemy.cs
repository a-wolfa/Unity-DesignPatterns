using UnityEngine;

namespace Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 3.0f;
        [SerializeField] private float chaseRange = 5.0f;

        private Transform _player;

        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            InitComponents();
        }

        private void InitComponents()
        {
            _player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        private void Update()
        {
            ChasePlayer();
        }

        private void ChasePlayer()
        {
            float distance = Vector3.Distance(_player.position, transform.position);
            
            if (distance < chaseRange)
            {
                Vector2 direction = (_player.position - transform.position).normalized;
                transform.position += (Vector3) direction * (moveSpeed * Time.deltaTime);
            }
        }
    }
}
