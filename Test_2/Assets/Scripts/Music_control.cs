using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Music_control : MonoBehaviour
{
    public Slider mySlider;
    AudioSource m_MyAudioSource;
    float m_MySliderValue;
    int s = 0;
    
    public GameObject a;
    public MainMenu script;
    //static GameObject instance = null;
    public GameObject[] objects;
    static Music_control instance;

    public GameObject m;
    public Script_first_load level_control_music;
    private void Awake()
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
    void Start()
    {
        script = a.GetComponent<MainMenu>();
        Debug.Log("NEW");
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();

        level_control_music = m.GetComponent<Script_first_load>();

    }    
    void Update()
    {
        ////DontDestroyOnLoad(this.gameObject);
        //m_MyAudioSource.volume = m_MySliderValue;
        //Debug.Log(mySlider.value);
        //m_MyAudioSource.volume = mySlider.value;
        Script_first_load.levelMusic = mySlider.value;      
        Debug.Log("levelMusic " + Script_first_load.levelMusic);
    }    
}