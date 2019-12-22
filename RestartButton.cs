using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public Button ilk;

    void Start()
    {
        ilk.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Depo.hiz = 3;
        //PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") + Depo.coin);
        Depo.alive = true;
        Depo.coin = 0;
    }

}
