using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvaController : MonoBehaviour
{
    public GameObject player;
    GameObject GM;
    public GameObject PauseMenu;
    public GameObject ListMenu;


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

        //when I press escape, the game will pause and the pause menu will appear
        if ((Input.GetKeyDown(KeyCode.Escape)))
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        if ((Input.GetKeyDown(KeyCode.L)))
        {
            ListMenu.SetActive(true);
            Time.timeScale = 0f;
        }


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
