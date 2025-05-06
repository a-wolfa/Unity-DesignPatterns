using System;
using MVVM.ViewModel;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace MVVM
{
    public class EnemyTest : MonoBehaviour
    {
        public PlayerViewModel viewModel;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TakeDamage(10);
            }
            
            if (Input.GetKeyDown(KeyCode.H))
            {
                Heal(10);
            }
        }

        public void TakeDamage(int amount)
        {
            viewModel.TakeDamage(amount);
        }
        
        public void Heal(int amount)
        {
            viewModel.Heal(amount);
        }
        
        
    }
}
