using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoldSayac : MonoBehaviour {

    public Text txt;

    void Start () {
        txt.text = "" + PlayerPrefs.GetInt("Coin");
    }
	
	void Update () {
        txt.text = "" + PlayerPrefs.GetInt("Coin");
    }
}
