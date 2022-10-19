using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScemeMgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Startbt()
    {
        SceneManager.LoadScene(0);
    }

    public void Mainbt()
    {
        SceneManager.LoadScene(1);
    }
}
