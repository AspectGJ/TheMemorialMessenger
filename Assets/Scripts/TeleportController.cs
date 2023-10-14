using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController: MonoBehaviour
{
    public GameObject exit;


   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if colling with player, teleport player to exit
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = exit.transform.position;
        }
    }

}
