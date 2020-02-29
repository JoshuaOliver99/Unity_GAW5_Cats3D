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

        if (Input.GetKey(KeyCode.A)) // left
        {
            camera.position += new Vector3(-1, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D)) // right
        {
            camera.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.W)) // up
        {
            camera.position += new Vector3(0, 0, 1);
        }
        else if (Input.GetKey(KeyCode.S)) // down
        {
            camera.position += new Vector3(0, 0, -1);
        }

        if (Input.GetKey(KeyCode.Escape)) // quit
        {
            Application.Quit();
        }
    }
}
