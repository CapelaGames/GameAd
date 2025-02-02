using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody)), RequireComponent(typeof(Collider))]
public class MoveToObject : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float maxDistance;
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        if (target == null) return;
        if (Vector3.Distance(transform.position, target.position) <= maxDistance):
        {
            Vector3 direction = target.position - transform.position;
            direction.Normalize();
            _rigidbody.MovePosition(transform.position + direction * (speed * Time.deltaTime)))
        }
    }
}
