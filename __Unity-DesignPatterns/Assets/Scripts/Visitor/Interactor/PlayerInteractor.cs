using System;
using UnityEngine;
using UnityEngine.UI;
using Visitor.Abstractions;
using Visitor.Interactable;
using Visitor.Interactable.Abstractions;

namespace Visitor.Interactor
{
    public class PlayerInteractor : MonoBehaviour
    {
        [SerializeField] private Button doorButton;
        [SerializeField] private Button chestButton;
        
        private IVisitor _interactionVisitor;
        
        private IInteractable _doorInteractable;
        private IInteractable _chestInteractable;

        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            InitCommands();
            InitComponents();
        }
        
        private void InitComponents()
        {
            _doorInteractable = FindFirstObjectByType<Door>();
            _chestInteractable = FindFirstObjectByType<TreasureChest>();
        }

        private void InitCommands()
        {
            doorButton.onClick.AddListener(() => Interact(_doorInteractable));
            chestButton.onClick.AddListener(() => Interact(_chestInteractable));
        }

        private void Start()
        {
            _interactionVisitor = new PlayerInteractionVisitor();
        }

        private void Interact(IInteractable interactable)
        {
            if (interactable != null)
            {
                interactable.Accept(_interactionVisitor);
            }
            else
            {
                Debug.Log("No interactable component found on the button.");
            }
        }
    }
}