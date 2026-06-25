using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject telaMorte;
    public GameObject telaVitoria;

    private bool jogoAcabou = false;

    void Start()
    {
        Time.timeScale = 1f;

        if (telaMorte != null)
            telaMorte.SetActive(false);

        if (telaVitoria != null)
            telaVitoria.SetActive(false);
    }

    public void Morrer()
    {
        if (jogoAcabou) return;

        jogoAcabou = true;

        if (telaMorte != null)
            telaMorte.SetActive(true);

        Time.timeScale = 0f;
    }

    public void Vencer()
    {
        if (jogoAcabou) return;

        jogoAcabou = true;

        if (telaVitoria != null)
            telaVitoria.SetActive(true);

        Time.timeScale = 0f;
    }

    public void Recomecar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}