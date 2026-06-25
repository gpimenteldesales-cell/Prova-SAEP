using UnityEngine;

public class VictoryItem : MonoBehaviour
{
    public GameOverManager gameOverManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameOverManager.Vencer();
        }
    }
}