using UnityEngine;

public interface IPlayerDataRepository
{
    PlayerData LoadPlayerData();
    void SavePlayerData(PlayerData playerData);
}
