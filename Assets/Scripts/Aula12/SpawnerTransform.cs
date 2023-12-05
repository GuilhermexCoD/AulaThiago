using UnityEngine;

public class SpawnerTransform : MonoBehaviour
{
    public GameObject prefab;

    public Vector3 initialPosition;

    public Vector3 offset;

    public int quantity;

    void Start()
    {
        for (int i = 0; i < quantity; i++)
        {
            GameObject clone = Instantiate(prefab);
            clone.transform.position = initialPosition + (offset * i);
        }
    }

    void CloneMatrix()
    {

        for (int i = 0; i < quantity; i++)
        {
            for (int j = 0; j < quantity; j++)
            {
                GameObject clone = Instantiate(prefab);
                clone.transform.position = initialPosition + new Vector3(i * offset.x, 0, j * offset.z);
            }
        }
    }

}
