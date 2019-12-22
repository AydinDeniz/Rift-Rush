using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hız : MonoBehaviour {

    public Rigidbody fizik;
    public int hiz;

	void Start ()
    {
        fizik.velocity = new Vector3(0, 0, hiz);
	}
}
