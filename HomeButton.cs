using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HomeButton : MonoBehaviour
{
    public Button m_YourFirstButton;

    void Start ()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
    }


    void TaskOnClick()
    {
        //PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") + Depo.coin);
        Depo.coin = 0;
        SceneManager.LoadScene(0);
    }
}
