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

    void Start()
    {
        script = a.GetComponent<MainMenu>();
        Debug.Log(script.sss);
        Debug.Log("NEW");
         
        if (s == 2)
        {
            if (m_MyAudioSource == null)
            {
                Destroy(this.gameObject);
                Debug.Log(s);
            }
        }
        
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();
        DontDestroyOnLoad(this.gameObject);
        
    }
    
    void Update()
    {
        //m_MyAudioSource.volume = m_MySliderValue;
        //Debug.Log(mySlider.value);

        ////m_MyAudioSource.volume = mySlider.value;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Destroy(this.gameObject);
            Debug.Log("Del");
        }
    }

    
}
