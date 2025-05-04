using System;
using UnityEngine;

namespace MVP.Model
{
    public class PlayerHealthModel
    {
        public event Action<int> OnHealthChanged;
        
        private int _health;
        public int MaxHealth { get; private set; }

        public PlayerHealthModel(int maxHealth)
        {
            MaxHealth = maxHealth;
            _health = MaxHealth;
        }

        public void TakeDamage(int damageAmount)
        {
            _health = Mathf.Max(0, _health - damageAmount);
            OnHealthChanged?.Invoke(_health);
        }
        
        public int GetHealth() => _health;
    }
}
