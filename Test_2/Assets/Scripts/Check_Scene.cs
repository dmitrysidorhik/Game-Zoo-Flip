using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Check_Scene : MonoBehaviour
{
    public int fort;
    Scene scene;
    public Script_first_load check;
    public GameObject q;
    private void Awake()
    {
        check = q.GetComponent<Script_first_load>();
    }
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    void Update()
    {
        if (scene.name == "New_Menu_Scene")
        {
            Script_first_load.check_num_scene = 1;
            fort = 1;
            Debug.Log("fort " + fort);
         }
        if (scene.name == "Game_Scene")
        {
            Script_first_load.check_num_scene = 2;
            fort = 2;
            Debug.Log("fort " + fort);

        }
        Debug.Log("Script_first_load.check_num_scene  " + Script_first_load.check_num_scene);
    }
}
