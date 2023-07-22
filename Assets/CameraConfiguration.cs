using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConfiguration : MonoBehaviour
{
    // Speed of camera moving through spaceship
    public float camSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(Time.deltaTime * camSpeed, 0, 0);
    }
}
