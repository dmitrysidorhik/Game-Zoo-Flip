using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_first_load : MonoBehaviour
{
    public static int maxMoney;

    //public GameObject a;
    public Player_control script;
    void Start()
    {

        DontDestroyOnLoad(this);
       // Debug.Log("maxMoney" + maxMoney);
        //script = a.GetComponent<Player_control>();
        //Debug.Log("GO" + script.score);
        SceneManager.LoadScene(1);
    }

    
    void Update()
    {
        //maxMoney++;
    }
}
