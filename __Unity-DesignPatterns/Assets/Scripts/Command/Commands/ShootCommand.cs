using Command.Abstractions;
using Command.Actors;

namespace Command.Commands
{
    public class ShootCommand : ICommand
    {
        private Player _player;

        public ShootCommand(Player player) => _player = player;
        
        public void Execute() => _player.Shoot();
    }
}