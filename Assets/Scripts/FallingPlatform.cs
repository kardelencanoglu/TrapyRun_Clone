using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    bool isFalling = false;
    float downSpeed = 0;

    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.name == "Player")
        {
            isFalling = true;
            //GameVariables.ammoCount += 2;
            Destroy(gameObject, 10);
        }
    }
    void Start()
    {

    }


    void Update()
    {
        if (isFalling)
        {
            downSpeed += Time.deltaTime / 10; //falling time
            transform.position = new Vector3(transform.position.x,
            transform.position.y - downSpeed,
            transform.position.z);
        }
    }
}