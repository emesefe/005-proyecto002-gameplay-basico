using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float upperLimit = 20f;
    public float lowerLimit = -10f;

    private void Update()
    {
        // LÍMITE INFERIOR -> ANIMALES NO ALIMENTADO
        if (transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
        }

        // LÍMITE SUPERIOR -> BALA FALLIDA
        if (transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }
    }
}
