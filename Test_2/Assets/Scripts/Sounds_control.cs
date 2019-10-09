using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sounds_control : MonoBehaviour
{
    public Slider mySlider_music;
    public AudioSource m_MyAudioSource_jump;
    public GameObject[] objects;
    static Sounds_control instance;
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
        //m_MyAudioSource = GetComponent<AudioSource>();
        //Jump_Play();
    }

    void Update()
    {
        m_MyAudioSource_jump.volume = mySlider_music.value;        
    }
    public void Jump_Play()
    {
        m_MyAudioSource_jump.Play();
    }
}
