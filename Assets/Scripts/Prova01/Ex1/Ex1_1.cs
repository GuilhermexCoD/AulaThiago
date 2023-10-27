using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1_1 : MonoBehaviour
{
    public Rigidbody rigidbody;

    void Start()
    {
        rigidbody.velocity = new Vector3(3, 0, 0);
    }
}
