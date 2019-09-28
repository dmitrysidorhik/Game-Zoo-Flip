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

    void Start()
    {
        Debug.Log("NEW");
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();
        DontDestroyOnLoad(this.gameObject);
        
    }
    
    void Update()
    {
        //m_MyAudioSource.volume = m_MySliderValue;
        //Debug.Log(mySlider.value);

        m_MyAudioSource.volume = mySlider.value;


    }
         
    
    
}
