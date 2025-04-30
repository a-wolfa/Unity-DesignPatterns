using UnityEngine;
using Visitor.Abstractions;
using Visitor.Interactable.Abstractions;

namespace Visitor.Interactable
{
    public class Door : MonoBehaviour, IInteractable
    {
        public bool IsLocked { get; private set; } = false;
        
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        
        public void Open()
        {
            Debug.Log("Door opened!");
        }
    }
}