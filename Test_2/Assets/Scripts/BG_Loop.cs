using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Loop : MonoBehaviour
{

    public float speed_back = 0.1f;
    private Vector2 offset = Vector2.zero;
    private Material material;
    void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = material.GetTextureOffset("_MainTex");
    }
    void Update()
    {
        offset.x += speed_back * Time.deltaTime;
        material.SetTextureOffset("_MainTex", offset);
    }
}
