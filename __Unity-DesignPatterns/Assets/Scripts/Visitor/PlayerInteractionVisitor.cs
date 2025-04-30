using UnityEngine;
using Visitor.Abstractions;
using Visitor.Interactable;
using Visitor.Interactable.Abstractions;

namespace Visitor
{
    public class PlayerInteractionVisitor : IVisitor
    {
        public void Visit(TreasureChest treasureChest)
        {
            treasureChest.Open();
        }

        public void Visit(Door door)
        {
            if (!door.IsLocked)
            {
                door.Open();
            }
            else
            {
                // Handle locked door interaction
                Debug.Log("The door is locked!");
            }
        }
    }
}