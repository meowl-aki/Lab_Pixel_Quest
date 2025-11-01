using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float jumpForce = 10;
    public float fallForce = 2;
    //Capsule
    public float CapsuleHeight = 0.25f;
    public float CapusuleRadius = 0.08f;

    //Ground Check
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;

    

    // Start is called before the first frame update
    void Start()
    {
      _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position, new Vector2(CapsuleHeight, CapusuleRadius), CapsuleDirection2D.Horizontal, 0, groundMask);

        if (Input.GetKeyDown(KeyCode.Space)&& (_groundCheck||waterCheck))
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);
        }

      
    }

    private bool waterCheck = false;
    private string waterTag = "Water";

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.CompareTag(waterTag))
        {
            waterCheck = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag(waterTag))
        {
            waterCheck = false;
        }
    }


}
