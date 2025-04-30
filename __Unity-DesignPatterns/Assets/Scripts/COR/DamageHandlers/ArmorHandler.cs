using COR.DamageHandlers.Base;
using UnityEngine;

namespace COR.DamageHandlers
{
    public class ArmorHandler : DamageHandler
    {
        public float armorValue = 5f;

        public override void HandleDamage(float damage)
        {
            float reducedDamage = Mathf.Max(damage - armorValue, 0f);
            Debug.Log($"Armor reduced damage from {damage} to {reducedDamage}");
            
            base.HandleDamage(reducedDamage);
        }
    }
}
