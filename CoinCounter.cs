using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CoinCounter : MonoBehaviour
{

    public Text txt;

    void Start()
    {
    }

    void Update()
    {

        if (Depo.alive)
        {
            txt.text = "" + Depo.coin;
        }
    }

}
