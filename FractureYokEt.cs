using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FractureYokEt : MonoBehaviour
{
	
	void Update ()
    {
        float konumx;
        float konumy;
        float konumz;

        bool kontrolx=true;

        konumx = gameObject.transform.position.x;
        konumx = gameObject.transform.position.y;
        konumx = gameObject.transform.position.z;

        if(konumx<10000 && konumx>-10000)
        {
            //be happy;
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("koyduk mu");
        }
    }
}
