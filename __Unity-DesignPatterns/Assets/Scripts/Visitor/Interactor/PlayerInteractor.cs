using System;
using UnityEngine;
using UnityEngine.UI;
using Visitor.Abstractions;
using Visitor.Interactable.Abstractions;

namespace Visitor.Interactor
{
    public class PlayerInteractor : MonoBehaviour
    {
        public Button doorButton;
        public Button chestButton;
        private IVisitor _interactionVisitor;

        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            InitCommands();
        }

        private void InitCommands()
        {
            doorButton.onClick.AddListener(() => ButtonAction(doorButton.GetComponent<IInteractable>()));
            chestButton.onClick.AddListener(() => ButtonAction(chestButton.GetComponent<IInteractable>()));
        }

        private void Start()
        {
            _interactionVisitor = new PlayerInteractionVisitor();
        }

        private void ButtonAction(IInteractable interactable)
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