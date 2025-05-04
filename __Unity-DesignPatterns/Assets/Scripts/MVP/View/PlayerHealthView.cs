using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace MVP.View
{
    public class PlayerHealthView : MonoBehaviour
    {
        [SerializeField] private Slider healthSlider;
        [SerializeField] private Button damageButton;

        public event Action OnDamageRequested;

        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            InitCommands();
        }

        private void InitCommands()
        {
            damageButton.onClick.AddListener(() => OnDamageRequested?.Invoke());
        }

        public void SetMaxHealth(int health)
        {
            healthSlider.maxValue = health;
        }

        public void UpdateHealth(int health)
        {
            healthSlider.value = health;
        }
    }
}
