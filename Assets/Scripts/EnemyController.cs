using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : HumanManager
{   
    public GameObject bulletEnemyPref;
    public Transform playerPos;
    float distance;
    [SerializeField] float maxDistance;

    // Start is called before the first frame update
    void Start()
    {
        hp = 3;
        if (playerPos != null)
        {
            distance = Vector3.Distance(transform.position, playerPos.position);
        }
        InvokeRepeating("Shoot", 0f, 2f);
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

}
