using COR.DamageHandlers.Base;
using UnityEngine;

namespace COR.DamageHandlers
{
    public class MagicBuffHandler : DamageHandler
    {
        public float reductionPercentage = 0.2f; // 20% reduction
        
        public override void HandleDamage(float damage)
        {
            float reducedDamage = damage * (1 - reductionPercentage);
            Debug.Log($"Magic buff reduced damage from {damage} to {reducedDamage}");
            
            base.HandleDamage(reducedDamage);
        }
    }
}