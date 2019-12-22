using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Revive : MonoBehaviour {


    public Button rev;
    public GameObject engelyokeden;
    public GameObject top;
    public GameObject deathmenu;
    public GameObject pausebutton;
    public Text startText;
    public GameObject txt;
    public GameObject particle;
    public GameObject kamera;
    public float ctdown;

    void Start()
    {
        rev.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        StartCoroutine(revprogress());
    }

    IEnumerator revprogress()
    {
        kamera.GetComponent<Orbit>().enabled = false;
        float Topx = top.transform.position.x;
        float Topy = top.transform.position.y;
        float Topz = top.transform.position.z;
        Instantiate(engelyokeden, new Vector3(Topx, Topy, Topz), Quaternion.Euler(0, 0, 0));
        deathmenu.GetComponent<Canvas>().enabled = false;
        txt.SetActive(true);
        Instantiate(particle, new Vector3(Topx, Topy + (float)0.2, Topz), Quaternion.Euler(0, 0, 0));
        startText.text = (3).ToString("0");
        yield return new WaitForSeconds(ctdown);
        startText.text = (2).ToString("0");
        yield return new WaitForSeconds(ctdown);
        startText.text = (1).ToString("0");
        yield return new WaitForSeconds(ctdown);
        startText.text = (0).ToString("0");
        Depo.alive = true;
        Destroy(particle);
        txt.SetActive(false);
        top.SetActive(true);
        kamera.GetComponent<Orbit>().enabled = true;
        pausebutton.SetActive(true);
        deathmenu.GetComponent<Canvas>().enabled = true;
        deathmenu.SetActive(false);
        //
        if (PlayerPrefs.HasKey("Coin"))
        {
            PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") - Depo.coin);
            PlayerPrefs.Save();
        }
        else
        {
            PlayerPrefs.SetInt("Coin", 0);
            PlayerPrefs.Save();
        }
        //
    }
}
