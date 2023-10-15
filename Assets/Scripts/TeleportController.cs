using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController: MonoBehaviour
{
    public GameObject exit;


   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if colling with player, teleport player to exit but don't change z position
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = new Vector3(exit.transform.position.x, exit.transform.position.y, collision.gameObject.transform.position.z);
        }
        
    }

}
