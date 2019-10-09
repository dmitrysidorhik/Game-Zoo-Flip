using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Game : MonoBehaviour
{
    public void return_menu()
    {
        SceneManager.LoadScene(1);
    }
    public void return_game()
    {
        SceneManager.LoadScene(2);

    }
}
