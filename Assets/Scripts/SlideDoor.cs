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
        switch (currentState)
        {
            case DoorStates.Closed:
                // Wait for 3 seconds before starting to open
                timer += Time.deltaTime;
                if (timer >= waitTime)
                {
                    currentState = DoorStates.Opening;
                    timer = 0.0f;
                }
                break;

            case DoorStates.Opening:
                // Move the door towards the opened position
                transform.position = Vector3.MoveTowards(transform.position, openedPosition, doorSpeed * Time.deltaTime);

                // Check if the door has reached the opened position
                if (Vector3.Distance(transform.position, openedPosition) < 0.01f)
                {
                    currentState = DoorStates.Opened;
                    timer = 0.0f;
                }
                break;

            case DoorStates.Opened:
                // Wait for 3 seconds before starting to close
                timer += Time.deltaTime;
                if (timer >= waitTime)
                {
                    currentState = DoorStates.Closing;
                    timer = 0.0f;
                }
                break;

            case DoorStates.Closing:
                // Move the door towards the closed position
                transform.position = Vector3.MoveTowards(transform.position, closedPosition, doorSpeed * Time.deltaTime);

                // Check if the door has reached the closed position
                if (Vector3.Distance(transform.position, closedPosition) < 0.01f)
                {
                    currentState = DoorStates.Closed;
                    timer = 0.0f;
                }
                break;
        }
    }
}
