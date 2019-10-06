using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas_load : MonoBehaviour
{
    public GameObject can;
    static Canvas_load instance;
    public GameObject[] objects;
    public Script_first_load check_Scene;
    public GameObject dr;
    void Awake()
    {
        if (instance == null)
        {
            for (int i = 0; i < objects.Length; i++)
                DontDestroyOnLoad(objects[i]);
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            for (int i = 0; i < objects.Length; i++)
                Destroy(objects[i]);
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        check_Scene = dr.GetComponent<Script_first_load>();
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("check_num_scene " + Script_first_load.check_num_scene);
        if (Script_first_load.check_num_scene == 1)
        {
            gameObject.SetActive(true);
        }
        if (Script_first_load.check_num_scene == 2)
        {
            gameObject.SetActive(false);
        }
    }
}
