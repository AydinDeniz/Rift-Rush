using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yaratici : MonoBehaviour
{
    GameObject kamera1;
    GameObject kamera2;
    public string levelName;
    AsyncOperation async;

    public void StartLoading()
    {
        StartCoroutine("load");
    }

    IEnumerator load()
    {
        Debug.LogWarning("ASYNC LOAD STARTED - " +
           "DO NOT EXIT PLAY MODE UNTIL SCENE LOADS... UNITY WILL CRASH");
        async = Application.LoadLevelAsync(levelName);
        async.allowSceneActivation = false;
        yield return async;
    }
    public void ActivateScene()
    {
        async.allowSceneActivation = true;
    }


    void Start()
    {
        int desertihtimal = Depo.desertihtimal;
        int forestihtimal = Depo.forestihtimal;
        int chessihtimal = Depo.chessihtimal;
        int candyihtimal = Depo.candyihtimal;
        int lavaihtimal = Depo.lavaihtimal;
        int iceihtimal = Depo.iceihtimal;
        int pirateihtimal = Depo.pirateihtimal;
        int skyihtimal = Depo.skyihtimal;
        int labihtimal = Depo.labihtimal;

        if (desertihtimal + chessihtimal + forestihtimal + candyihtimal + lavaihtimal + iceihtimal + pirateihtimal + skyihtimal == 0)
        {
            desertihtimal = 1;
            forestihtimal = 1;
            chessihtimal = 1;
            candyihtimal = 1;
            lavaihtimal = 1;
            iceihtimal = 1;
            pirateihtimal = 1;
            skyihtimal = 1;
            labihtimal = 1;
        }

        if (GameObject.Find("Top_Desert") != null)
        {
            Depo.desertihtimal = 0;
            desertihtimal = 0;
        }

        if (GameObject.Find("Top_Forest") != null)
        {
            Depo.forestihtimal = 0;
            forestihtimal = 0;
        }

        if (GameObject.Find("Top_Chess") != null)
        {
            Depo.chessihtimal = 0;
            chessihtimal = 0;
        }
        if (GameObject.Find("Top_Lava") != null)
        {
            Depo.lavaihtimal = 0;
            lavaihtimal = 0;
        }

        if (GameObject.Find("Top_Ice") != null)
        {
            Depo.iceihtimal = 0;
            iceihtimal = 0;
        }
        if (GameObject.Find("Top_Lab") != null)
        {
            Depo.labihtimal = 0;
            labihtimal = 0;
        }
        if (GameObject.Find("Top_Pirate") != null)
        {
            Depo.pirateihtimal = 0;
            pirateihtimal = 0;
        }
        if (GameObject.Find("Top_Sky") != null)
        {
            Depo.skyihtimal = 0;
            skyihtimal = 0;
        }

        int toplam = desertihtimal + chessihtimal + forestihtimal + lavaihtimal + iceihtimal + pirateihtimal + skyihtimal+labihtimal;
        int t = Random.Range(1, toplam + 1);

        int olasilik1, olasilik2, olasilik3, olasilik4, olasilik5, olasilik6, olasilik7, olasilik8;

        olasilik1 = (desertihtimal) * desertihtimal;
        olasilik2 = (desertihtimal + forestihtimal) * forestihtimal;
        olasilik3 = (desertihtimal + forestihtimal + chessihtimal) * chessihtimal;
        olasilik4 = (desertihtimal + forestihtimal + chessihtimal + labihtimal) * labihtimal;
        olasilik5 = (desertihtimal + forestihtimal + chessihtimal + labihtimal + lavaihtimal) * lavaihtimal;
        olasilik6 = (desertihtimal + forestihtimal + chessihtimal + labihtimal + lavaihtimal + iceihtimal) * iceihtimal;
        olasilik7 = (desertihtimal + forestihtimal + chessihtimal + labihtimal + lavaihtimal + iceihtimal + pirateihtimal) * pirateihtimal;
        olasilik8 = (desertihtimal + forestihtimal + chessihtimal + labihtimal + lavaihtimal + iceihtimal + pirateihtimal + skyihtimal) * skyihtimal;


        if (t == olasilik1)
        {
            levelName = "Desert";
            StartLoading();
        }
        if (t == olasilik2)
        {
            levelName = "Forest";
            StartLoading();
        }
        if (t == olasilik3)
        {
            levelName = "Chess";
            StartLoading();
        }
        if (t == olasilik4)
        {
            levelName = "Lava";
            StartLoading();
        }
        if (t == olasilik5)
        {
            levelName = "Ice";
            StartLoading();
        }
        if (t == olasilik6)
        {
            levelName = "Pirate";
            StartLoading();
        }
        if (t == olasilik7)
        {
            levelName = "Sky";
            StartLoading();
        }
        if (t == olasilik8)
        {
            levelName = "Green tekno";
            StartLoading();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "portal")
        {
            ActivateScene();

            if (Depo.hiz <= 6)
            {
                Depo.hiz = Depo.hiz*108/100;
            }
        }

    }
}
