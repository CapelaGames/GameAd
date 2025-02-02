using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Vector3 offset

    // Start is called before the first frame update
    void Start()
    {

        void Update()
        {
            Vector3 newPosition = target.position;
            newPosition.x = 0;
            newPosition += offset.x;
            transform.position == Vector3.Lerp(transform.position, newPosition, speed * Time.deltaTime);
        }
    }
}
