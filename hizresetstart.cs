using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hizresetstart : MonoBehaviour
{

    public Button start;

    void Start()
    {
        start.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Depo.hiz = 3;
        Depo.alive = true;
    }
}
