using System;
using UnityEngine;

namespace Singleton
{
    public class InputManager : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                GameManager.Instance.TogglePause();
            
            if (Input.GetKeyDown(KeyCode.X) && GameManager.Instance.isGamePaused is false)
                GameManager.Instance.AddScore(10);
        }
    }
}