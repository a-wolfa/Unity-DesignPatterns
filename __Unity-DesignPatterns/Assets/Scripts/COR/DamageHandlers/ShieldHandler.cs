using COR.DamageHandlers.Base;
using UnityEngine;

namespace COR.DamageHandlers
{
    public class ShieldHandler : DamageHandler
    {
        public float shieldValue = 10f;

        public override void HandleDamage(float damage)
        {
            var absorbed = Mathf.Min(damage, shieldValue);
            shieldValue -= absorbed;
            
            float remainingDamage = damage - absorbed;
            Debug.Log($"Shield absorbed: {absorbed}, Remaining damage: {remainingDamage}");
            
            base.HandleDamage(remainingDamage);
        }
    }
}
