using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvaController : MonoBehaviour
{
    public GameObject player;
    GameObject GM;


    public TextMeshProUGUI playerHp;

    public GameObject gun;
    public GameObject knife;
    public GameObject lantern;


    // Start is called before the first frame update
    void Start()
    {
        playerHp.text = player.GetComponent<PlayerController>().hp.ToString();
        GM = GameObject.FindGameObjectWithTag("GM");

        Check();

    }

    // Update is called once per frame
    void Update()
    { 
        if(player != null)
        {
            playerHp.text = player.GetComponent<PlayerController>().hp.ToString();
        }
        

        Check();





    



    }

    public void Check()
    {
        if (GM != null)
        {
            GameManager gameManager = GM.GetComponent<GameManager>();

            gun.SetActive(gameManager.gun);
            knife.SetActive(gameManager.knife);
            lantern.SetActive(gameManager.lantern);
        }
            
    }

}
