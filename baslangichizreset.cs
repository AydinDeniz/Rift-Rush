using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class baslangichizreset : MonoBehaviour
{
    public Button start;

    void Start()
    {
        start.onClick.AddListener(TaskOnClick);
    }


    void TaskOnClick()
    {
        Depo.hiz = 3;
    }
}