using UnityEngine;

public class Teste : MonoBehaviour
{


    // Awake chamado quando o objeto é criado
    private void Awake()
    {
        Debug.Log("AWAKE");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
    }

    private void Update()
    {
        Debug.Log("UPDATE");
    }

    private void OnDestroy()
    {
        Debug.Log("DESTROY");
    }
}