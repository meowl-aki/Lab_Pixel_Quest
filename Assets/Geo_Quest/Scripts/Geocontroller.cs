using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;



public class GeoController: MonoBehaviour
{
    /*
    //string Hello = ("Hello");
    */
    private int varOne = 3;
    public float speed = 5;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        /*
        // Debug.Log("Hello World!");
        // string World = ("world");
        // Debug.Log(Hello + World);
        */
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(varOne++);
        /*
        //rb.velocity = new Vector2(-1, rb.velocity.x);
        */
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 (xInput * speed, rb.velocity.y);
        Debug.Log(xInput);
    }

    private void()
                
}
