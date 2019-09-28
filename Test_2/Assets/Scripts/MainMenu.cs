using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sss = 0;
    public void PlayGame()
    {
        sss++;
        SceneManager.LoadScene(1);
        
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
     
}
