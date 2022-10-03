using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
