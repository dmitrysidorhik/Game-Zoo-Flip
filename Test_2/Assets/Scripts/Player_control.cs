using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_control : MonoBehaviour
{
    public float speed = 10f;
     
    public bool grounded = false;
    public Transform groundCheck;
    public float groungRadius = 0.2f;
    public LayerMask whatIsGround;
    public int score  = 0;
    public int max_score = 0;
    private Rigidbody2D rig;

    public Text moneyText;
    public Text max_moneyText;

    public GameObject b;
    public Script_first_load max_score_script;

    public AudioSource m_MyAudioSource_Jump;
    public AudioSource m_MyAudioSource_Dead;
    public AudioSource m_MyAudioSource_Star;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        max_score_script = b.GetComponent<Script_first_load>();

        m_MyAudioSource_Jump.GetComponent<AudioSource>();
        m_MyAudioSource_Dead.GetComponent<AudioSource>();
        m_MyAudioSource_Star.GetComponent<AudioSource>();

    }

    void Update()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groungRadius, whatIsGround);
        float move;

        move = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(move * speed, rig.velocity.y);
         
         
        if ((Input.GetKeyDown(KeyCode.UpArrow) && grounded) || (Input.touchCount>0 && grounded))
        {
            m_MyAudioSource_Jump.Play();
            rig.AddForce(new Vector2(0, 700f));
            Debug.Log("Jump");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
            Debug.Log("BackMenu");
        }

        moneyText.text = "" + score;
        if (Script_first_load.maxMoney < score)
        {
            Script_first_load.maxMoney = score;
        }        
        max_moneyText.text = "" + Script_first_load.maxMoney;

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PolygonCollider2D>().tag == "star")
        {
            m_MyAudioSource_Star.Play();
            Destroy(col.gameObject);
            score++;
        }
        if (col.GetComponent<PolygonCollider2D>().tag == "dead_saw")
        {
            m_MyAudioSource_Dead.Play();
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }
    
}
