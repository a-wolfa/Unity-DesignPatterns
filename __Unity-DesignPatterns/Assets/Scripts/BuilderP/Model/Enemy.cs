using System;
using UnityEngine;

namespace BuilderP.Model
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed = 3.0f;
        [SerializeField] private float _chaseRange = 5.0f;

        [SerializeField] private Transform _Player;

        private void Update()
        {
            ChasePlayer();
        }

        private void ChasePlayer()
        {
            float distance = Vector3.Distance(_Player.position, transform.position);
            
            if (distance < _chaseRange)
            {
                Vector2 direction = (_Player.position - transform.position).normalized;
                transform.position += (Vector3) direction * (_moveSpeed * Time.deltaTime);
            }
        }
    }
}
