using UnityEngine;

public class VictoryItem : MonoBehaviour
{
    public GameOverManager gameOverManager;

    void Start()
    {
        if (gameOverManager == null)
            gameOverManager = FindFirstObjectByType<GameOverManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameOverManager.Vencer();
        }
    }
}