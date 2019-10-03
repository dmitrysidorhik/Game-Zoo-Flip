using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_first_load : MonoBehaviour
{
    public int s = 4;

    public GameObject a;
    public Player_control script;
    void Start()
    {

        DontDestroyOnLoad(this);
        Debug.Log("s" + s);
        script = a.GetComponent<Player_control>();
        Debug.Log("GO" + script.score);
        SceneManager.LoadScene(1);
    }

    
    void Update()
    {
       
    }
}
