using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Camera camera;

    void Start()
    {
        camera = Camera.main;
    }
    private void FixedUpdate()
    {
        camera.transform.position = transform.position - new Vector3(0,0,10);
    }

}
