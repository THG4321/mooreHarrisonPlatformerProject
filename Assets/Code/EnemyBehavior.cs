using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    Vector3 playerPos;
    public float enemySpeed;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = Player.transform.position;

        transform.position = Vector2.MoveTowards(transform.position, playerPos, enemySpeed * Time.deltaTime);
    }
}
