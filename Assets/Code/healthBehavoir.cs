using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthBehavoir : MonoBehaviour
{
    public GameObject hP1;
    public GameObject hP2;
    public GameObject hP3;


    private float startingHealth = 3;
    public float currentHealth;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
         
        if (currentHealth == 3)
        {
            //player hurt
            hP1.GetComponent<SpriteRenderer>().enabled = true;
            hP2.GetComponent<SpriteRenderer>().enabled = true;
            hP3.GetComponent<SpriteRenderer>().enabled = true;
        }

        else if(currentHealth == 2)
        {
            hP3.GetComponent<SpriteRenderer>().enabled = false;

        }

        else if(currentHealth == 1)
        {
            hP2.GetComponent<SpriteRenderer>().enabled = false;
        }

        else
        {
            hP1.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Stuff");
        if (collision.gameObject.transform.tag == "Enemy" && !PlayerMovement.InGroundPound)
        {
            TakeDamage(1f);
        }
    }

    private void Update()
    {
        if(currentHealth <= 0)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = (false);
            currentHealth = 3;
            Invoke("ResetPlayer", 1f);
        }
    }

    private void ResetPlayer()
    {
        SceneManager.LoadScene(0);
    }
} 
