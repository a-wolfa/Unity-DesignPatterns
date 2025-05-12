using Assets.Scripts.Observer.Subjects;
using MVP.Model;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health palyerHealth;
    [SerializeField] private Image fillImage;

    private void OnEnable()
    {
        palyerHealth.OnHealthChanged += UpdateHealthBar;
    }

    private void OnDisable()
    {
        palyerHealth.OnHealthChanged -= UpdateHealthBar;
    }

    private void UpdateHealthBar(float normalizedHealth)
    {
        fillImage.fillAmount = normalizedHealth;
    }

}
