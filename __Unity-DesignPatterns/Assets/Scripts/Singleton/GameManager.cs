using System;
using UnityEngine;

namespace Singleton
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        public int score;
        public bool isGamePaused;

        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            InitInstance();
        }

        private void InitInstance()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        public void AddScore(int amount)
        {
            score += amount;
            Debug.Log(score);
        }

        public void TogglePause()
        {
            isGamePaused = !isGamePaused;
            Time.timeScale = isGamePaused ? 0 : 1;
        }
        
    }
}