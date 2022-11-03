using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    Rigidbody2D rb;

    public float upForce;
    public float forwardForce;
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();  
    }

    private void Update()
    {
        BirdJump();
    }

    public void BirdJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector2(forwardForce,upForce));
        }
    }
}
