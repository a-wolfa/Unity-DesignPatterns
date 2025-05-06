using MVP.Model;
using MVP.View;
using UnityEngine;

namespace MVP.Presenter
{
    public class PlayerHealthPresenter : MonoBehaviour
    {
        [SerializeField] private PlayerHealthView view;
        
        private PlayerHealthModel _model;

        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            _model = new PlayerHealthModel(100);
            view.SetMaxHealth(_model.MaxHealth);
            view.UpdateHealth(_model.GetHealth());
            
            InitCommands();
        }

        private void InitCommands()
        {
            view.OnDamageRequested += HandleDamage;
            _model.OnHealthChanged += view.UpdateHealth;
        }

        private void HandleDamage()
        {
            _model.TakeDamage(10);
        }

        private void OnDestroy()
        {
            view.OnDamageRequested -= HandleDamage;
            _model.OnHealthChanged -= view.UpdateHealth;
        }
    }
}
