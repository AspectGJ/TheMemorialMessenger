using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
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
        transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
    }



}
