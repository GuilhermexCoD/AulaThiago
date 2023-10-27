using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1_4 : MonoBehaviour
{

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(3, 0, 0) * Time.fixedDeltaTime;

        //Escrito de outra maneira mas as duas instruções são as mesmas
        //transform.position = transform.position + new Vector3(3, 0, 0) * Time.fixedDeltaTime;
    }
}
