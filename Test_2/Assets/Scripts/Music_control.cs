using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Music_control : MonoBehaviour
{
    public Slider mySlider_music;
    public AudioSource m_MyAudioSource;
    public GameObject[] objects;
    static Music_control instance;
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
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();
    }    
    void Update()
    {        
        m_MyAudioSource.volume = mySlider_music.value;
        Script_first_load.levelMusic = mySlider_music.value;      
        Debug.Log("levelMusic " + Script_first_load.levelMusic);
    }    
}