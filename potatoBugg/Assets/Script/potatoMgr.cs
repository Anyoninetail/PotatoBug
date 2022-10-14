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
    public bool isGround = true;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        moveX = Input.GetAxisRaw("Horizontal") * moveSpeed;

        rb.velocity = new Vector2(moveX, rb.velocity.y);


        transform.Rotate(new Vector3(0, 0, -(transform.rotation.z + moveSpeed) * Input.GetAxisRaw("Horizontal")));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        


        Debug.DrawRay(rb.position, Vector3.down, new Color(1, 0, 1));


        RaycastHit2D rayHit = Physics2D.Raycast(rb.position, Vector3.down, rayleng, LayerMask.GetMask("Platform"));

        if (rayHit.collider != null)
        {
            Debug.Log(rayHit.collider.name);
        }

        if (rayHit.collider.tag == "Ground")
        {
            jumpcount = 0;
        }

    }
}
