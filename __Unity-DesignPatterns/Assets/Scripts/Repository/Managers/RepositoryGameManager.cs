using UnityEngine;

public class RepositoryGameManager : MonoBehaviour
{
    private IPlayerDataRepository _playerDataRepository;
    private PlayerData _playerData;

    private void Awake()
    {
        // Initialize the repository
        _playerDataRepository = new PlayerDataRepository();

        // Load player data
        _playerData = _playerDataRepository.LoadPlayerData();
    }

    public void UpdateScore(int newScore)
    {
        _playerData.highScore = Mathf.Max(_playerData.highScore, newScore);
        _playerDataRepository.SavePlayerData(_playerData);
    }

    public int GetHighScore()
    {
        return _playerData.highScore;
    }
}
