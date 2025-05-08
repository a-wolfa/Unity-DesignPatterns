using UnityEngine;

public class SetScoreTester : MonoBehaviour
{
    [SerializeField] private RepositoryGameManager gameManager;
    [SerializeField] private int testScore;

    private void Start()
    {
        SetScore();
    }

    public void SetScore()
    {
        gameManager.UpdateScore(testScore);
        Debug.Log($"HighScore is: {gameManager.GetHighScore()}");
    }
}
