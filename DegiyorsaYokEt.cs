using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegiyorsaYokEt : MonoBehaviour {


    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.transform.position.y >= transform.position.y && coll.gameObject.CompareTag("engel"))
        {
            Destroy(gameObject);
        }
    }
}
