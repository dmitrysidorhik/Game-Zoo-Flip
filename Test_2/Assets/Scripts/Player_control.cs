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
    public float score  = 0;
    private Rigidbody2D rig;

    public Text moneyText;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

     void Update()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groungRadius, whatIsGround);
        float move;

        move = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(move * speed, rig.velocity.y);
         
         
        if ((Input.GetKeyDown(KeyCode.UpArrow) && grounded) || (Input.touchCount>0 && grounded))
        {
            rig.AddForce(new Vector2(0, 700f));
            Debug.Log("Jump");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
            Debug.Log("BackMenu");
        }
        moneyText.text = "" + score;

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PolygonCollider2D>().tag == "star")
        {
            Destroy(col.gameObject);
            score++;
        }
    }

}
