using UnityEngine;
using UnityEngine.Events;

public class MouseInput : MonoBehaviour
{
    public UnityEvent OnLeftMouseDown;
    public UnityEvent OnRightMouseDown;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            OnLeftMouseDown?.Invoke();
            Debug.Log("Left Mouse Button Down");
        }

        if (Input.GetMouseButtonDown(1))
        {
            OnRightMouseDown?.Invoke();
            Debug.Log("Right Mouse Button Down");
        }
    }
}
