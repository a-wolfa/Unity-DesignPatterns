using UnityEngine;

namespace Behaviours
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 5f;

        private Rigidbody2D _rb;
        private Vector2 _movement;
    
        private void Awake()
        {
            Init();
        }

        private void Update()
        {
            HandleInput();
        }

        private void FixedUpdate()
        {
            Move();
        }

        private void Init()
        {
            InitComponents();
        }

        private void InitComponents()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void HandleInput()
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");
            _movement.Normalize();
        }

        private void Move()
        {
            _rb.MovePosition(_rb.position + _movement * (moveSpeed * Time.deltaTime));
        }
    }
}
