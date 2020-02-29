using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardHandler : MonoBehaviour
{
    public GameObject territory;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (territory.activeSelf == true)
                territory.SetActive(false);
            else
                territory.SetActive(true);
        }
    }
}
