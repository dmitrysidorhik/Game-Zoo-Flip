using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_first_load : MonoBehaviour
{
    public static int maxMoney;
    public static float levelMusic;
    public static int check_num_scene;
    public Player_control script;
    void Start()
    {     
        SceneManager.LoadScene(1);
    }        
    void Update()
    {

    }
}
