using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    Vector3 playerPos;
    public float enemySpeed;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Templar1");
        playerPos = Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = Player.transform.position;

        transform.position = Vector2.MoveTowards(transform.position, playerPos, enemySpeed * Time.deltaTime);
    }


}
