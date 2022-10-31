using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBehavoir : MonoBehaviour
{
    public Vector2 ShootSpeed;

    public Vector2 ShootSpeedLeft;

    private bool isshooting;

    public float shootTimer;
    public Transform shootPos;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        isshooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //StartCoroutine(Shoot());
            Shoot();


        }


        Vector3 aim = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    }
    public void Shoot()
        
    {
        GameObject newbullet = Instantiate(bullet, shootPos.position + new Vector3( 1, 0), Quaternion.identity);
        if(FindObjectOfType<PlayerMovement>().facingRight)
        {
            newbullet.GetComponent<Rigidbody2D>().velocity = ShootSpeed;
        }

        else
        {
            newbullet.GetComponent<Rigidbody2D>().velocity = ShootSpeedLeft;
        }
    }

    int direction()
    {
        if(transform.localScale.x < 0f)
        {
            return -1;
        }
        else
        {
            return +1;
        }
    }

}
