using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    
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
    
}
