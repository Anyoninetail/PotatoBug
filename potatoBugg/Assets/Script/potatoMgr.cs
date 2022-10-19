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
    public GameObject MoveBtn;



    public int jumpcount;
    public int maxJumpCount = 2;

    int left_velue;
    int right_velue;
    bool left_up;
    bool left_down;
    bool right_up;
    bool right_down;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()    
    {
        Time.timeScale = 1;
        Gmsetting.SetActive(false);
        MoveBtn.SetActive(true);
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        moveX = Input.GetAxisRaw("Horizontal") * moveSpeed;

        moveX = (right_velue + left_velue)  * moveSpeed;

        rb.velocity = new Vector2(moveX, rb.velocity.y);
        
        transform.Rotate(new Vector3(0, 0, -(transform.rotation.z + (moveSpeed * 2)) * Input.GetAxisRaw("Horizontal")));

        transform.Rotate(new Vector3(0, 0, -(transform.rotation.z + (moveSpeed * 2)) * (right_velue + left_velue)));

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "end")
        {
            Debug.Log("¾Æ¾ß");
            Gmsetting.SetActive(true);
            MoveBtn.SetActive(false);
            Time.timeScale = 0;
        }
    }

    public void Gomane()
    {
        SceneManager.LoadScene(0);
    }

    public void BtnDown(string type)
    {
        switch (type)
        {
            case "L":
                left_velue = -1;
                left_down = true;
                break;
            case "R":
                right_velue = 1;
                right_down = true;
                break;
        }
    }

    public void BtnUp(string type)
    {
        switch (type)
        {
            case "L":
                left_velue = 0;
                left_up = true;
                break;
            case "R":
                right_velue = 0;
                right_up = true;
                break;
        }
    }

}
