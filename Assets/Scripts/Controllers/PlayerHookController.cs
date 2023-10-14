using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHookController : MonoBehaviour
{
    
    

    

    private void Start()
    {
        //get player object with tag "Player"
        
        
    }

    private void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if player collides with hook
        if (other.gameObject.CompareTag("Hook"))
        {
            //destroy hook in 3 seconds
            Destroy(other.gameObject, 3f);
            
        }
    }

    

   
}
