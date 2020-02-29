using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Territory : MonoBehaviour
{
    [SerializeField]
    GameObject playerCharacter;

    public float territoryControl = 50;
    bool isOwned;

    private void Start()
    {
        if (territoryControl < 100)
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (territoryControl < 200)
            gameObject.GetComponent<Renderer>().material.color = Color.green;
    }

    void Update()
    {
        if (playerCharacter.transform.position.x > (transform.position.x - 25) // If Player inside the zone bounds
            && playerCharacter.transform.position.x < (transform.position.x + 25)
            && playerCharacter.transform.position.z > (transform.position.z - 25)
            && playerCharacter.transform.position.z < (transform.position.z + 25))
        {
            if (territoryControl <= 200) // If territoryControl Less than max
                territoryControl += Time.deltaTime * 10;

            if (territoryControl > 100) 
            {
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                isOwned = true;
            }
            else
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                isOwned = false;
            }

        }


    }
}
