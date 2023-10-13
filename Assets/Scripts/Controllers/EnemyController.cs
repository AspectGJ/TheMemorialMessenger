using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : HumanManager
{   
    public GameObject bulletEnemyPref;
    public Transform playerPos;
    float distance;
    [SerializeField] float maxDistance;

    GameObject GM;

    // Start is called before the first frame update
    void Start()
    {
        hp = 3;
        if (playerPos != null)
        {
            distance = Vector3.Distance(transform.position, playerPos.position);
        }
        InvokeRepeating("Shoot", 0f, 2f);

        GM = GameObject.FindGameObjectWithTag("GM");

    }

    

    // Update is called once per frame
    void Update()
    {
        if (playerPos != null)
        {
            distance = Vector3.Distance(transform.position, playerPos.position);
        }
        
    }

    public void Shoot()
    {
        GameObject newBullet;
        if (distance <= maxDistance)
        {
            newBullet = Instantiate(bulletEnemyPref, transform.position + new Vector3(-0.8f, 0, 0), Quaternion.identity);
        }
    }

    //if enemy get trigger by player's box collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //if player is using knife
            if (GM.GetComponent<GameManager>().knife)
            {
                //enemy get damage
                hp -= 1;
                print("enemy hp: " + hp);
                //if enemy's hp is 0
                if (hp <= 0)
                {
                    //enemy is dead
                    Destroy(gameObject);
                }
            }
            
        }
    }


}
