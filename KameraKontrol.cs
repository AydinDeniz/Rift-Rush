using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{

    public GameObject Top;
    Vector3 mesafe;


    void Start ()
    {
        mesafe = transform.position - Top.transform.position;
	}
	
	
	void LateUpdate () {


        transform.position = new Vector3(transform.position.x, transform.position.y, Top.transform.position.z +mesafe.z);

    }

}
