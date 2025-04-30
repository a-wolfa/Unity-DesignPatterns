using System;
using COR.DamageHandlers;
using COR.DamageHandlers.Base;
using UnityEngine;

namespace COR.Managers
{
    public class DamageManager : MonoBehaviour
    {
        // public ArmorHandler armor;
        // public ShieldHandler shield;
        // public MagicBuffHandler magicBuff;

        public GameObject warrior;
        private DamageHandler[] _damageHandlers;

        private void Start()
        {
            // armor.SetNextHandler(shield);
            // shield.SetNextHandler(magicBuff);
            //
            // armor.HandleDamage(30f); // Example damage value
            
            _damageHandlers = warrior.GetComponents<DamageHandler>();
            
            if (_damageHandlers.Length == 0)
            {
                Debug.LogError("No DamageHandler components found on this GameObject.");
                return;
            }
            
            for (int i = 0; i < _damageHandlers.Length - 1; i++)
            {
                _damageHandlers[i].SetNextHandler(_damageHandlers[i + 1]);
            }
            
            _damageHandlers[0].HandleDamage(30f); // Example damage value
        }
    }
}