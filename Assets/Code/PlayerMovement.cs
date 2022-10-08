using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 JumpForce = new Vector2(0, 300);

    public Rigidbody2D Rb2d;

    private bool beenHit = false;
     
    public float Speed;

    public bool OnGround;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if we should jump
        bool shouldJump = (Input.GetKeyUp(KeyCode.Space));

        if (shouldJump && !beenHit && OnGround)
        {
            // Reset velocity and then jump up
            Rb2d.velocity = Vector2.zero;
            Rb2d.AddForce(JumpForce);

        }

        // Moves player left and right
        float xMove = Input.GetAxis("Horizontal");

        

        // How we get there
        Vector3 newPos = transform.position;

        // Change the posistion on the Y Axis
        newPos += new Vector3(xMove * Speed * Time.deltaTime, 0);



        //Set up object's posititon to our new one
        transform.position = newPos;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.tag == "Ground")
        {
            OnGround = true;
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.transform.tag == "Ground")
        {
            OnGround = false;
            Debug.Log(true);
        }
    }
   
}
