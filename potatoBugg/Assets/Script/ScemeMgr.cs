using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScemeMgr : MonoBehaviour
{

    public void Startbt()
    {
        SceneManager.LoadScene(1);
    }

    public void Mainbt()
    {
        SceneManager.LoadScene(0);
    }
}
