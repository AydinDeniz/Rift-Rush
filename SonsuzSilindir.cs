using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonsuzSilindir : MonoBehaviour
{

    public GameObject yol;
    public GameObject Top;

    void Update()
    {


        float topz = Top.transform.position.z;
        float silindirz = this.transform.position.z;


        if (topz - silindirz > 1400)
        {
            GameObject.Instantiate(yol, new Vector3(0, 0, this.transform.position.z + 4800), Quaternion.Euler(new Vector3(90, 0, 0)));
            Destroy(gameObject);
        }
    }
}
