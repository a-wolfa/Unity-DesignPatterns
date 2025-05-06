using System;
using MVVM.Model;
using UnityEngine;

namespace MVVM.ViewModel
{
    public class PlayerViewModel : MonoBehaviour
    {
        public event Action<float> OnHealthChanged;

        private PlayerModel _model;

        private void Start()
        {
            _model = new PlayerModel(100);
            NotifyHealthChanged();
        }

        public void TakeDamage(int amount)
        {
            _model.TakeDamage(amount);
            NotifyHealthChanged();
        }

        public void Heal(int amount)
        {
            _model.Heal(amount);
            NotifyHealthChanged();
        }

        private void NotifyHealthChanged()
        {
            float healthPercent = (float) _model.CurrentHealth / _model.MaxHealth;
            OnHealthChanged?.Invoke(healthPercent);
        }
    }
}
