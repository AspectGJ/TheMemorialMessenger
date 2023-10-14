using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public int whichItem = 0;

    public void StartButton()
    {
        //upload the game scene indexed 2
        SceneManager.LoadScene(2);
        
    }

    public void QuitButton()
    {
        //quit the game
        Application.Quit();
    }

    public void MenuButton()
    {
        //upload the menu scene indexed 1
        SceneManager.LoadScene(0);
    }

    public void TutorialButton()
    {
        //upload the game scene indacaexed 2
        SceneManager.LoadScene(1);
    }

    public void XButton()
    {
          //when I press the X button, the pause menu will disappear and the game will continue
        Time.timeScale = 1f;
        //get parent of the button
        GameObject parent = transform.parent.gameObject;
        parent.SetActive(false);
    }

    public void button1()
    {
          whichItem = 1;
        
    }
    public void button2()
    {
        whichItem = 2;

    }
    public void button3()
    {
        whichItem = 3;

    }
    public void button4()
    {
        whichItem = 4;

    }


}
