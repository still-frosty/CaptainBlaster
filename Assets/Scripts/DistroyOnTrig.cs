using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistroyOnTrig : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
