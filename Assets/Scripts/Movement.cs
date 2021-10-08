using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Movement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public float Speed = 10.0f; //Hastigheten vi rör oss/Timothy


    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();    //Hämtar den komponent vi vill använda/Timothy
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * Speed, vertical * Speed);
    }
}