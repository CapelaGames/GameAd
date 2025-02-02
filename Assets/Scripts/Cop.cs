using System.Collections;
using System.Collections.Generic;

[RequireComponents(typeof(MoveToObjects))]
public class Cop : MonoBehavior
{
    using UnityEngine;
    MoveToObject moveToObject;
Minions minions;
float radius = f3;

void Start()
{
    moveToObject = GetComponent<MoveToObject>();
    minions = FindObjectOfType<Minions>();
}

void FixedUpdate()
{
    Collider[] nearMinions = Physics.OverlapSphere(transform.position, radius, 1 << LayerMask.NameToLayer("Minion"));

    if (nearMinions.Length > 0)

        moveToObject.target = nearMinions[0].transform;
}

    }

    void OnCollisionEnter(Collision collision
    {
        if (collision.gameObject.tag == "Minion")
{
    minions.RemoveMinion(collision.gameObject);
    Destroy(collision.gameObject);
    Destroy(gameObject);
