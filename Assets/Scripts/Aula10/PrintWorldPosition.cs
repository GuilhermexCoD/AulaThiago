using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintWorldPosition : MonoBehaviour
{

    public Vector3 worldPosition;
    public Vector3 localPosition;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Posicao no mundo : {transform.position}");
        Debug.Log($"Posicao Local ou posicao em relacao ao Parent : {transform.localPosition}");
    }

    private void Update()
    {
        worldPosition = transform.position;
        localPosition = transform.localPosition;
    }
}
