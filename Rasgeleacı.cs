using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rasgeleacı : MonoBehaviour {
    public int acımin = 0;
    public int acımax = 359;
	
	void Start () {
        
        int random = Random.Range(acımin, acımax);
        transform.Rotate(this.transform.rotation.x, random, this.transform.rotation.z);
    }
	
	
}
