using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    Vector3 startingPosition;
    float direction;
    [SerializeField] float maxMovementDistance = 3f;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        startingPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        // Get the current enemy position.
        Vector3 currentPosition = transform.position;

        // Compare the current position to the starting position:
        //   - if it is further to the left, then it should be moving to the right
        //   - otherwise, if it is further to the right, then it should be moving to the left
        if (currentPosition.x <= startingPosition.x)
        {
            direction = 1f;
        }
        else if (currentPosition.x >= startingPosition.x + maxMovementDistance)
        {
            direction = -1f;
        }

        // Set the velocity. The direction variable determines the sign of the X velocity.
        myRigidbody.linearVelocity = new Vector2(direction, 0);

    }
}