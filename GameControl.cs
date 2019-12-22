using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static int desertihtimal, forestihtimal, chessihtimal;
	void Start ()
    {
        
        int t = Random.Range(1,3);

        if(t == 1)
        {
            SceneManager.LoadScene("Desert_Canvas");

        }
        if (t == 2)
        {
            SceneManager.LoadScene("Desert_Canvas");

        }
        if (t == 3)
        {
            SceneManager.LoadScene("Desert_Canvas");

        }
    }
}
