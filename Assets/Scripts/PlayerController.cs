using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    [SerializeField] float runSpeed = 5f;
    [SerializeField] float jumpSpeed = 5f;
    Collider2D myCollider;
    LifeKeeper theLifeKeeper;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        theLifeKeeper = FindFirstObjectByType<LifeKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Jump();
    }
    private void Run()
    {
        float controlDirection = Input.GetAxis("Horizontal");
        Vector2 playerVelocity = new Vector2(controlDirection * runSpeed,
            myRigidbody.linearVelocity.y);
        myRigidbody.linearVelocity = playerVelocity;

    }

    private void Jump()
    {
        if (!myCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            return;
        }

        if (Input.GetButtonDown("Jump")) //If we're pressing the spacebar
        {
            Vector2 jumpVelocityToAdd = new Vector2(0f, jumpSpeed);
            myRigidbody.linearVelocity += jumpVelocityToAdd;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        theLifeKeeper.DecreaseLives();
        Destroy(gameObject);
    }


}