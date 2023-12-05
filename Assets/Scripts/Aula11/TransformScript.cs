using UnityEngine;

public class TransformScript : MonoBehaviour
{
    [Tooltip("O quanto o GameObject vai deslocar em um intervalo de tempo de 1 segundo.")]
    public float speed = 1f;

    [Tooltip("Quanto tempo em segundos o GameObject vai se locomover.")]
    public float timeToMove;

    /// <summary>
    /// Tempo decorrido em que o GameObject foi criado.
    /// </summary>
    private float elapsedTime;


    // Update is called once per frame
    void Update()
    {
        //Debug.Log($"Delta Time {Time.deltaTime}");
        MoveDeltaTime();
    }

    /// <summary>
    /// O GameObject se move diferente dependendo do FPS
    /// </summary>
    private void MoveNoDeltaTime()
    {
        //jogo rodando em 10 FPS e
        //o cubo tem um incremento de 0.5f na posicao x
        //10 * 0.5 = 5
        //30 * 0.5 = 15
        //250 * 0.5 = 125

        //FRAME 1
        //transform.position =                          (2, 0, 0)
        //new Vector3(1, 0, 0) =                        (1, 0, 0)
        //transform.position + new Vector3(1, 0, 0) =   (3, 0, 0)

        //FRAME 2
        //transform.position =                          (3, 0, 0)
        //new Vector3(1, 0, 0) =                        (1, 0, 0)
        //transform.position + new Vector3(1, 0, 0) =   (4, 0, 0)
        if (elapsedTime < timeToMove)
        {
            elapsedTime += Time.deltaTime;
            Vector3 newPosition = transform.position + new Vector3(speed, 0, 0);
            transform.position = newPosition;
        }
    }

    /// <summary>
    /// O GameObject se move igual independente do FPS
    /// </summary>
    private void MoveDeltaTime()
    {
        //jogo rodando em 10 FPS e
        //o cubo tem um incremento de 0.5f na posicao x
        //FPS * speed * Time.deltaTime
        //10 * 0.5 * 0.1 = 0.5
        //30 * 0.5 * 0.033 = 0.495
        //250 * 0.5 * 0.0036 = 0.45

        if (elapsedTime < timeToMove)
        {
            elapsedTime += Time.deltaTime;
            Vector3 newPosition = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
            transform.position = newPosition;
        }
    }
}
