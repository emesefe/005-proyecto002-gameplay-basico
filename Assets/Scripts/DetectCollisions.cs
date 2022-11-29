using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); // Destruye el proyectil
        Destroy(other.gameObject); // Destruye el animal con el que colisiono
    }
}
