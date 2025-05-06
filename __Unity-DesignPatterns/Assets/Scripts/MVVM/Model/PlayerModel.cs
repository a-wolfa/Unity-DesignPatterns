using UnityEngine;

namespace MVVM.Model
{
    public class PlayerModel
    {
        public int MaxHealth { get; private set; }
        public int CurrentHealth { get; private set; }

        public PlayerModel(int maxHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = MaxHealth;
        }

        public void TakeDamage(int amount)
        {
            CurrentHealth = Mathf.Max(0, CurrentHealth - amount);
        }
        
        public void Heal(int amount)
        {
            CurrentHealth = Mathf.Min(MaxHealth, CurrentHealth + amount);
        }
    }
}
