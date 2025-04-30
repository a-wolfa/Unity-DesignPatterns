using UnityEngine;
using Visitor.Abstractions;
using Visitor.Interactable.Abstractions;

namespace Visitor.Interactable
{
    public class TreasureChest : MonoBehaviour, IInteractable
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Open()
        {
            Debug.Log("Treasure chest opened! Loot gained!");
        }
    }
}