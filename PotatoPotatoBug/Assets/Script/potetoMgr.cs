using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potetoMgr : MonoBehaviour
{
    public float moveX;


    public float speeeeeed;
    public float moveSpeed;

    Rigidbody2D rb;


    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*moveX = Input.GetAxisRaw("Horizontal") * speeeeeed;

        rb.velocity = new Vector2(moveX, rb.velocity.y);*/

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, Time.deltaTime * moveSpeed, Space.Self);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -Time.deltaTime * moveSpeed, Space.Self);
        }
    }
}
