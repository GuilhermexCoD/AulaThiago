using UnityEngine;

public class SpawnerTransform : MonoBehaviour
{
    public GameObject prefab;

    [Tooltip("A distancia entre cada clone para o eixo x, y e z")]
    public Vector3 offset;

    [Tooltip("A quantidade de clones na Coluna(x) e Linha(y)")]
    public Vector2Int quantity;

    public RotationRange xRotationRange;
    public RotationRange yRotationRange;
    public RotationRange zRotationRange;

    void Start()
    {
        CloneMatrixPattern(quantity.x, quantity.y);
    }

    /// <summary>
    /// Clona o prefab em um padrao de matrix
    /// </summary>
    /// <param name="columnQuantity"></param>
    /// <param name="rowQuantity"></param>
    void CloneMatrixPattern(int columnQuantity, int rowQuantity)
    {

        for (int column = 0; column < columnQuantity; column++)
        {
            CloneRowPattern(rowQuantity, column);
        }
    }

    /// <summary>
    /// Clona o prefab em um padrao de linha
    /// </summary>
    /// <param name="rowQuantity"></param>
    /// <param name="column"></param>
    private void CloneRowPattern(int rowQuantity, int column)
    {
        for (int row = 0; row < rowQuantity; row++)
        {
            GameObject clone = Instantiate(prefab);

            //Modificando a posicao do Clone
            Vector3 vectorA = transform.position;
            Vector3 vectorB = new Vector3(column * offset.x, 0, row * offset.z);
            Vector3 clonePosition = vectorA + vectorB;
            clone.transform.position = clonePosition;

            //Modificando a rotacao do Clone
            float xRandom = Random.Range(xRotationRange.min, xRotationRange.max);
            float yRandom = Random.Range(yRotationRange.min, yRotationRange.max);
            float zRandom = Random.Range(zRotationRange.min, zRotationRange.max);

            clone.transform.rotation = Quaternion.Euler(xRandom, yRandom, zRandom);
        }
    }

    //Clique com o botao direito do mouse no script attachado no gameobject
    //e procure pela funcao CloneInspectorButton
    [ContextMenu(nameof(CloneInspectorButton))]
    void CloneInspectorButton()
    {
        CloneMatrixPattern(quantity.x, quantity.y);
    }
}
