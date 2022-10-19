using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class potatoMgr : MonoBehaviour
{
    public float moveSpeed;
    public float moveX;
    public float jumpPower;
    public float rayleng;

    public GameObject Gmsetting;



    public int jumpcount;
    public int maxJumpCount = 2;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()    
    {
        Gmsetting.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        moveX = Input.GetAxisRaw("Horizontal") * moveSpeed;

        rb.velocity = new Vector2(moveX, rb.velocity.y);
        
        transform.Rotate(new Vector3(0, 0, -(transform.rotation.z + moveSpeed) * Input.GetAxisRaw("Horizontal")));

    }

    public void OnCollision2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Gmsetting.SetActive(true);
        }
    }

    public void Gomane()
    {
        SceneManager.LoadScene(0);
    }


}
