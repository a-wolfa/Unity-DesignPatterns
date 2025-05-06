using System;
using MVVM.ViewModel;
using UnityEngine;
using UnityEngine.UI;

namespace MVVM.View
{
    public class PlayerHealthView : MonoBehaviour
    {
        public PlayerViewModel viewModel;
        public Slider healthSlider;

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
            viewModel.OnHealthChanged += UpdateHealthUI;
            healthSlider.onValueChanged.AddListener(UpdateHealthUI);
        }

        private void RemoveCommands()
        {
            viewModel.OnHealthChanged -= UpdateHealthUI;
            healthSlider.onValueChanged.RemoveAllListeners();
        }

        private void UpdateHealthUI(float healthPercent)
        {
            healthSlider.value = healthPercent;
        }

        private void OnDestroy()
        {
            RemoveCommands();
        }
    }
}
