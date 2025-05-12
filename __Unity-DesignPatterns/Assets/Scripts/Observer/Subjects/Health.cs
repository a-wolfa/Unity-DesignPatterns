using System;
using UnityEngine;

namespace Assets.Scripts.Observer.Subjects
{
    public class Health : MonoBehaviour
    {
        public event Action<float> OnHealthChanged;

        [SerializeField] private float maxHealth = 100f;
        private float currentHealth;

        private void Start()
        {
            currentHealth = maxHealth;
            NotifyHealthChanged();
        }

        public void TakeDamage(float amount)
        {
            currentHealth = Mathf.Max(currentHealth - amount, 0);
            NotifyHealthChanged();
        }

        public void Heal(float amount)
        {
            currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
            NotifyHealthChanged();
        }

        private void NotifyHealthChanged()
        {
            OnHealthChanged?.Invoke(currentHealth / maxHealth);
        }
    }
}