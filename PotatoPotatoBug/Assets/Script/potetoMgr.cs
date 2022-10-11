using UnityEngine;

public class potetoMgr : MonoBehaviour
{



    
    public float moveSpeed;

  


    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, -(transform.rotation.z + moveSpeed) * Input.GetAxisRaw("Horizontal")));
    }
}
