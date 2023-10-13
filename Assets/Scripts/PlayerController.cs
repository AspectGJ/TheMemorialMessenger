using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool islookingRight;
    float horizontal = 0f;
    float speed = 5f;

    public GameObject bulletPref;

    // Start is called before the first frame update
    void Start()
    {
        islookingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        // move with horizontal axis
        horizontal = Input.GetAxis("Horizontal");   
        transform.position += new Vector3(horizontal, 0, 0) * Time.deltaTime * speed;

        // if player is looking right and moving left, flip
        if (horizontal < 0 && islookingRight)
        {
            Flip();
        }
        if (horizontal > 0 && !islookingRight)
        {
            Flip();
        }

        //get objects in an array with the tag "bullet"
        GameObject[] bullets = GameObject.FindGameObjectsWithTag("bullet");
        


        //instantiating bullet with spacebar
        if (Input.GetKeyDown(KeyCode.Space) && bullets.Length == 0)
        {
            Vector3 bulletSpawnPosition = islookingRight ? new Vector3(0.8f, 0, 0) : new Vector3(-0.8f, 0, 0);
            GameObject newBullet = Instantiate(bulletPref, transform.position + bulletSpawnPosition, Quaternion.identity);
            newBullet.GetComponent<BulletController>().speed = islookingRight ? Mathf.Abs(newBullet.GetComponent<BulletController>().speed) : -Mathf.Abs(newBullet.GetComponent<BulletController>().speed);
        }


    }

    void Flip()
    {
        islookingRight = !islookingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
