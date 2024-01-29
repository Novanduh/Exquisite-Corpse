using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(0f, 1.36f, 0f);
    }
}
