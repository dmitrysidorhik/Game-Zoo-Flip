using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_control : MonoBehaviour
{
    public float speed = 10f;
   // public bool grounded = false;
   // public Transform groundCheck;
   // public float groungRadius = 0.2f;
   // public LayerMask whatIsGround;

    private Rigidbody2D rig;
     void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

     void Update()
    {
     //   grounded = Physics2D.OverlapCircle(groundCheck.position, groungRadius, whatIsGround);
        //float move;

        //move = Input.GetAxis("Horizontal");
        //rig.velocity = new Vector2(move * speed, rig.velocity.y);
         
         
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rig.AddForce(new Vector2(0, 700f));
            Debug.Log("Jump");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
            Debug.Log("BackMenu");
        }
    }
    
}
