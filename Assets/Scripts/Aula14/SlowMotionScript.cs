using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotionScript : MonoBehaviour
{
    public float timeScale;

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = timeScale;
        
    }
}
