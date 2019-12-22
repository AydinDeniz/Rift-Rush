using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterOnCollision : MonoBehaviour
{   public bool testshatter=false;
    public GameObject replacement;
    GameObject OyunKontrol;
    OyunKontrol kontrol;
    GameObject SoundController;
    public GameObject kamera;
    public GameObject deathcanvas;
    public GameObject pausecanvas;
    public GameObject pause;

    void Start()
    {
       SoundController= GameObject.FindGameObjectWithTag("SoundController");
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "yokolcakengel")
        {
            Depo.alive = false;
            kamera.GetComponent<Orbit>().enabled = false;
            if (testshatter == false)
            {
                GameObject.Instantiate(replacement, transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            else
            {

                gameObject.transform.GetChild(0).GetComponent<testshatter>().Detonate();
            }
            gameObject.SetActive(false);
            deathcanvas.SetActive(true);
            pausecanvas.SetActive(false);
            pause.SetActive(false);
            if (PlayerPrefs.HasKey("Coin"))
            {
                PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") + Depo.coin);
                PlayerPrefs.Save();
            }
            else
            {
                PlayerPrefs.SetInt("Coin", Depo.coin);
                PlayerPrefs.Save();
            }
        }
        if (other.tag == "coin")
        {
            Destroy(other.gameObject);
            Depo.coin += 1;
            SoundController.GetComponent<Manager>().Playsound("coin");
            
        }
    }
}
