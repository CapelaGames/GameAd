using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DoorStates
{
    Opened,
    Closed,
    Opening,
    Closing
}

public class SlideDoor : MonoBehaviour
{
    public float doorSpeed = 2.0f; // Speed at which the door opens/closes
    public float waitTime = 3.0f; // Time to wait in opened/closed state

    private DoorStates currentState = DoorStates.Closed;
    private float timer = 0.0f;
    private Vector3 closedPosition;
    private Vector3 openedPosition;

    void Start()
    {
        // Store the initial position of the door as the closed position
        closedPosition = transform.position;

        // Calculate the opened position based on the door's initial position
        openedPosition = closedPosition + new Vector3(0, 2, 0); // Adjust the Vector3 to match your door's movement direction
    }

    void Update()
    {
        /* STUDENT MODIFICATION AREA: 
         Use the enum to control how the door opens and close, keeping track of its state
       */
    }
}
