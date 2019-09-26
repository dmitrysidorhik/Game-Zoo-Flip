using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_control : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody2D rb;
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

     void Update()
    {
        float moveY = Input.GetAxis("Vertical");
         
        rb.MovePosition(rb.position + Vector2.up*moveY*speed*Time.deltaTime);
    }
}
