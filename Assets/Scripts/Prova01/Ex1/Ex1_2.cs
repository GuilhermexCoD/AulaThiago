using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1_2 : MonoBehaviour
{
    public Rigidbody rigidbody;

    void Update()
    {
        rigidbody.AddForce(new Vector3(3, 0, 0));
    }
}
