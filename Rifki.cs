using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifki : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        float mesafe = this.transform.position.x + this.transform.position.y + this.transform.position.z;
        if (mesafe < 10000 & mesafe > -10000)
        {

        }
        else
        {
            Destroy(this);
        }
    }


}
