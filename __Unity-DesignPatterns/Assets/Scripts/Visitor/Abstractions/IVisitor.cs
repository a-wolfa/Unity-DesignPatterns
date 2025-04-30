using Visitor.Interactable;
using Visitor.Interactable.Abstractions;

namespace Visitor.Abstractions
{
    public interface IVisitor
    {
        void Visit(TreasureChest treasureChest);
        void Visit(Door door);
    }
}
