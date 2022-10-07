using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potetoMgr : MonoBehaviour
{
    
    public float moveSpeed;

    Rigidbody2D rb;


    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("Left"))
        {

        }
    }
}
