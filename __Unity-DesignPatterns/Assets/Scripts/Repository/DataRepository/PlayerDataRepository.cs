using UnityEngine;

public class PlayerDataRepository : IPlayerDataRepository
{
    private const string PlayerDataKey = "PLAYER_DATA";

    public PlayerData LoadPlayerData()
    {
        if (!PlayerPrefs.HasKey(PlayerDataKey))
            return new PlayerData();

        string json = PlayerPrefs.GetString(PlayerDataKey);
        return JsonUtility.FromJson<PlayerData>(json);
    }

    public void SavePlayerData(PlayerData playerData)
    {
        string json = JsonUtility.ToJson(playerData);
        PlayerPrefs.SetString(PlayerDataKey, json);
        PlayerPrefs.Save();
    }
}
