using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Music_control : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    float m_MySliderValue;
    int s = 0;
    public Slider mySlider;
    public GameObject a;
    public MainMenu script;
    //static GameObject instance = null;
    public GameObject[] objects;
    static Music_control instance;
  /* private void Awake()
    {
        if (instance == null)
        {
            for (int i = 0; i < objects.Length; i++)
                DontDestroyOnLoad(objects[i]);
            Debug.Log("IF");
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            for (int i = 0; i < objects.Length; i++)
                Destroy(objects[i]);
            
            Destroy(gameObject);
            Debug.Log("ELSE");
        }
    } 
    void Start()
    {
        script = a.GetComponent<MainMenu>();
        Debug.Log("NEW");
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();

    }    
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
        //m_MyAudioSource.volume = m_MySliderValue;
        //Debug.Log(mySlider.value);
        m_MyAudioSource.volume = mySlider.value;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Destroy(this.gameObject);
            Debug.Log("Del");
        }
    }    
}