using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform player;

    public float suavidade = 5f;
    public float alturaAoPular = 1f;
    public float tempoCameraAlta = 0.4f;

    private float yInicial;
    private float zInicial;
    private float tempoPulo;

    void Start()
    {
        yInicial = transform.position.y;
        zInicial = transform.position.z;
    }

    void LateUpdate()
    {
        if (player == null) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            tempoPulo = tempoCameraAlta;
        }

        if (tempoPulo > 0)
        {
            tempoPulo -= Time.deltaTime;
        }

        float yDesejado = yInicial;

        if (tempoPulo > 0)
        {
            yDesejado = yInicial + alturaAoPular;
        }

        Vector3 posicaoDesejada = new Vector3(
            player.position.x,
            yDesejado,
            zInicial
        );

        transform.position = Vector3.Lerp(
            transform.position,
            posicaoDesejada,
            suavidade * Time.deltaTime
        );
    }
}