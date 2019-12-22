using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tamamenrasgeleacı : MonoBehaviour {

   

    void Start()
    {
       
        int random = Random.Range(0, 359);
        int random1 = Random.Range(0, 359);
        int random2 = Random.Range(0, 359);
        transform.Rotate(random1, random, random2);

      











    }


}
