using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Scoreboard : MonoBehaviour {

    public Text txt;

    public float scorecount;
    public float pointspersecond = 10;

    void Start()
    {
    }

    void Update()
    {
        if (Depo.hiz > 3 && Depo.hiz <= 4)
            pointspersecond = 15;
        if (Depo.hiz > 4 && Depo.hiz <= 5)
            pointspersecond = 20;
        if (Depo.hiz > 5 && Depo.hiz <= 6)
            pointspersecond = 25;

        if (Depo.alive) {
            scorecount += pointspersecond * Time.deltaTime;
            Depo.scoreboard = (long)(scorecount);
            txt.text = "" + Mathf.Round(Depo.scoreboard) + "0";
        }
    }

}
