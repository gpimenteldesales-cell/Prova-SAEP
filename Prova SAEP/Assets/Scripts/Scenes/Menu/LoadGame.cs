using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string nomeCenaJogo = "Fase1";

    public void Jogar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(nomeCenaJogo);
    }

    public void Sair()
    {
        Debug.Log("Saiu do jogo");
        Application.Quit();
    }
}