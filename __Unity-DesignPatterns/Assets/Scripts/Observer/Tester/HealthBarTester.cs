using Assets.Scripts.Observer.Subjects;
using UnityEngine;

public class HealthBarTester : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    
    public void Damge() => playerHealth.TakeDamage(10);
    public void Heal() => playerHealth.Heal(10);
}
