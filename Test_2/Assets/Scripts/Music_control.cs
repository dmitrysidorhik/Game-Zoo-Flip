using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music_control : MonoBehaviour
{
    AudioSource m_MyAudioSource;
     float m_MySliderValue;

    public Slider mySlider;

    void Start()
    {
        //Initiate the Slider value to half way
        m_MySliderValue = 0.1f;
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        //Play the AudioClip attached to the AudioSource on startup
        m_MyAudioSource.Play();
    }

     void Update()
    {
        m_MyAudioSource.volume = m_MySliderValue;
        m_MyAudioSource.volume = mySlider.value;
        Debug.Log(mySlider.value);
        DontDestroyOnLoad(this.gameObject);
    }
    
}
