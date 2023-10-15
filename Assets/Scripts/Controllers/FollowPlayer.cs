using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public Vector3 offset;

    void Start()
    {
        offset = new Vector3(38, 20, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //follow player but keep the same z position with offset
        if (player != null)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z) + offset;
        }
        

        
    }
}
