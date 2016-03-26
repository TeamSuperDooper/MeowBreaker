using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    //this is the movement speed of the paddle
    public float movementSpeed = 150;

    //this creates a reference to the rigidbody on the paddle
    public Rigidbody2D rb2d;

    //this runs every frame. even if their computer is slower or fasted this will run the same speed.
    void FixedUpdate()
    {

        //get horizontal movement from axis
        float hor = Input.GetAxisRaw("Horizontal");

        // Set Velocity (movement direction * speed)
        rb2d.velocity = Vector2.right * hor * movementSpeed;
    }
}
