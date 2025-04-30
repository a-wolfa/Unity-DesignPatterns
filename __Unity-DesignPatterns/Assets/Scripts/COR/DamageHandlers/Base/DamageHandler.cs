using UnityEngine;

namespace COR.DamageHandlers.Base
{
    public class DamageHandler : MonoBehaviour
    {
        protected DamageHandler NextHandler;
        
        public void SetNextHandler(DamageHandler next)
        {
            NextHandler = next;
        }

        public virtual void HandleDamage(float damage)
        {
            if (NextHandler != null)
            {
                NextHandler.HandleDamage(damage);
            }
            else
            {
                Debug.Log($"Final damage applied: {damage}");
            }
        }
    }
}
