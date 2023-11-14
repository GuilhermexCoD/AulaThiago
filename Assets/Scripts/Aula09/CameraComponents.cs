using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraComponents : MonoBehaviour
{
    public Camera camera;

    public Transform cameraTransform;
    public float fovSpeed;
    public AudioListener cameraAudioListener;

    public GameObject lightGameObject;
    private Light light;


    private void Awake()
    {
        cameraTransform = camera.GetComponent<Transform>();
        cameraAudioListener = camera.GetComponent<AudioListener>();

        light = lightGameObject.GetComponent<Light>();
        light.color = Color.black;
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            camera.fieldOfView += 1 * Time.deltaTime * fovSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            camera.fieldOfView -= 1 * Time.deltaTime * fovSpeed;
        }
    }
}
