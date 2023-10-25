using UnityEngine;

public class Teste : MonoBehaviour
{
    // Awake chamado quando o objeto é criado
    //private void Awake()
    //{
    //    Debug.Log("AWAKE");
    //}

    // Start is called before the first frame update
    void Start()
    {
        int materialIndex = Random.Range(0, 15);
        Debug.Log("Material Index: " + materialIndex);
    }

    //private void Update()
    //{
    //    Debug.Log("UPDATE");
    //}

    //private void OnDestroy()
    //{
    //    Debug.Log("DESTROY");
    //}

}