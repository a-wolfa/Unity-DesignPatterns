using Visitor.Abstractions;

namespace Visitor.Interactable.Abstractions
{
    public interface IInteractable
    {
        void Accept(IVisitor visitor);
    }
}