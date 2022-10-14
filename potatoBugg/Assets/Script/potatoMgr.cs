using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potatoMgr : MonoBehaviour
{
    public float moveSpeed;
    public float moveX;
    public float jumpPower;
    public float rayleng;


    public int jumpcount;
    public int maxJumpCount = 2;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //moveX = Input.GetAxisRaw("Horizontal") * moveSpeed;

        //rb.velocity = new Vector2(moveX, rb.velocity.y);

        transform.Rotate(new Vector3(0, 0, -(transform.rotation.z + (moveSpeed / 2)) * Input.GetAxisRaw("Horizontal")));

    }

   
}
