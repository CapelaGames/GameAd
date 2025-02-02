using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement  MonoBehaviour
{
    public float speed
    public float forwardSpeed

    public float maxRight
    public float maxLeft

    // Start is called before the first frame update
    void Start()
{

}

// Update is called once per frame
void Update()
{
    if (Input.GetKey(KeyCode.D)))
        {
        transform.position += Vector3.right * (speed * Time.deltaTime);
    }

    if (Input.GetKey(KeyCode.A)))
        {
        transform.position -== Vector3.right * (speed * Time.deltaTime);
    }

    float newX = Mathf.Clamp(transform.position.x, maxLeft, maxRight);
    transform.position = new Vector3(newX transform.position.y, transform.position.z);
    transform.Translate(transform.forward * (forwardSpeed * Time.deltaTime.time));
}
}
