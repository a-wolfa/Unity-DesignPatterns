using System.Collections.Generic;
using Command.Abstractions;
using Command.Actors;
using Command.Commands;
using UnityEngine;

namespace Command.Handlers
{
    public class InputHandler : MonoBehaviour
    {
        private Dictionary<KeyCode, ICommand> _commands = new();

        private Player _player;
        
        private void Start()
        {
            _player = FindAnyObjectByType<Player>();

            _commands[KeyCode.Space] = new JumpCommand(_player);
            _commands[KeyCode.F] = new ShootCommand(_player);
        }

        private void Update()
        {
            HandleInput();
        }

        public void BindKeys(KeyCode key, ICommand command)
        {
            _commands[key] = command;
        }
        
        public void HandleInput()
        {
            foreach (var kvp in _commands)
            {
                if (Input.GetKeyDown(kvp.Key))
                {
                    kvp.Value.Execute();
                }
            }
        }
    }
}