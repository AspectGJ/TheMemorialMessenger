using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HumanManager : MonoBehaviour
{
    public int hp;
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
            hp -= 1;
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
