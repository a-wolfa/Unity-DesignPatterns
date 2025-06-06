using Command.Abstractions;
using Command.Actors;

namespace Command.Commands
{
    public class JumpCommand : ICommand
    {
        private Player _player;
        
        public JumpCommand(Player player) => _player = player;
        
        public void Execute() => _player.Jump();
    }
}