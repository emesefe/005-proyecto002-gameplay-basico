using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40f;

    private void Update()
    {
        // Mover hacia adelante a la velocidad speed
        transform.Translate(Vector3.forward * 
                            speed * Time.deltaTime);
    }
}
