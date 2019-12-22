using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopSkin : MonoBehaviour {

    public GameObject[] balls;

	void Start ()
    {
        
        if(PlayerPrefs.GetString("CurSkin")=="atom")
        {
            GameObject top = Instantiate(balls[0], transform.position, new Quaternion(0, 0, 0, 0));
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            top.transform.parent = gameObject.transform;
            gameObject.GetComponent<ShatterOnCollision>().testshatter = true;

        }
        else if (PlayerPrefs.GetString("CurSkin") == "spike")
        {
            GameObject top = Instantiate(balls[1], transform.position, new Quaternion(0, 0, 0, 0));
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            top.transform.parent = gameObject.transform;
            gameObject.GetComponent<ShatterOnCollision>().testshatter = true;
        }
        else if (PlayerPrefs.GetString("CurSkin") == "wood")
        {
            GameObject top = Instantiate(balls[2], transform.position, new Quaternion(0, 0, 0, 0));
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            top.transform.parent = gameObject.transform;
            gameObject.GetComponent<ShatterOnCollision>().testshatter = true;
        }
        else if (PlayerPrefs.GetString("CurSkin") == "metal")
        {
            GameObject top = Instantiate(balls[3], transform.position, new Quaternion(0, 0, 0, 0));
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            top.transform.parent = gameObject.transform;
            gameObject.GetComponent<ShatterOnCollision>().testshatter = true;
        }
        
    }
	
	
}
