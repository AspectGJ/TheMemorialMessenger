using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyController : MonoBehaviour
{
    public float speed = 10f;
    public float destroyDelay = 4f;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyDelay);
    }

    // Update is called once per frame
    void Update()
    {
        // move bullet
        transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {   if(collision.gameObject.CompareTag("Player")) 
        {
            Destroy(gameObject);
        }
        
    }
}
