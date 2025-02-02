using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    Minions minions;
    void Start()
    {
        minions = FindObjectOfType<Minions>();
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Bounds")
        {
            minions.RemoveMinion(gameObject);
            Destroy(gameObject);
        }
    }
}
