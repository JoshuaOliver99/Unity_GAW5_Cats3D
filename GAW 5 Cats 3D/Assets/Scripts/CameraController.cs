using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Transform camera;

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
        {
            camera.position += new Vector3(0, -1, 0);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
        {
            camera.position += new Vector3(0, 1, 0);
        }
    }
}
