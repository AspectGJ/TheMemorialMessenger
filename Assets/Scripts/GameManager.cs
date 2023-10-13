using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gun = true;
    public bool knife = false;
    public bool lantern = false;


    GameObject player;

    BoxCollider2D knifeCollider;

    // Start is called before the first frame update
    void Start()
    {
        gun = true;
        knife = false;
        lantern = false;

        player = GameObject.FindGameObjectWithTag("Player");
        
        // get player's box collider
        knifeCollider = player.GetComponent<BoxCollider2D>();
        
        //make it false
        knifeCollider.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            
            gun = true;
            knife = false;
            lantern = false;

            knifeCollider.enabled = false;

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            
            gun = false;
            knife = true;
            lantern = false;

            knifeCollider.enabled = true;
            
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            
            gun = false;
            knife = false;
            lantern = true;

            knifeCollider.enabled = false;

        }





    }
}
