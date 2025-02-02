using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveToObject))]
public class Cop : MonoBehaviour
{
    MoveToObject moveToObject;
    Minions minions;
    float radius = 3f;

    void Start()
    {
        moveToObject = GetComponent<MoveToObject>();
        minions = FindObjectOfType<Minions>();
    }

    void FixedUpdate()
    {
        Collider[] nearMinions = Physics.OverlapSphere(transform.position, radius, 1 << LayerMask.NameToLayer("Minion"));

        if (nearMinions.Length > 0)
        {
            moveToObject.target = nearMinions[0].transform;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Minion")
        {
            minions.RemoveMinion(collision.gameObject);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
