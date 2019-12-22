using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desert_world : MonoBehaviour {

    public int objno;
    public Renderer rend;
    
    public GameObject crystal;

    // Use this for initialization
    void Start() {
        if (desert_depo.deserto[objno]==0)
        {
            rend.enabled = false;
           
        }
        else
        {
            rend.enabled = true;
            Object.Destroy(crystal);
        }
	}
	
	
}
                  