using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 jumpforce = new Vector2(0, 300);

    public Rigidbody2D Rb2d;

    private bool beenhit = false;

    public float Speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if we should jump
        bool shouldJump = (Input.GetKeyUp(KeyCode.Space));

        if (shouldJump && !beenhit)
        {
            // Reset velocity and then jump up
            Rb2d.velocity = Vector2.zero;
            Rb2d.AddForce(jumpforce);

        }

        // Moves player up and down
        float xMove = Input.GetAxis("Horizontal");

        

        // How we get there
        Vector3 newPos = transform.position;

        // Change the posistion on the Y Axis
        newPos += new Vector3(xMove * Speed * Time.deltaTime, 0);



        //Set up object's posititon to our new one
        transform.position = newPos;
    }
}
