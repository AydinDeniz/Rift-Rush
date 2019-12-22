using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerkezeAcila : MonoBehaviour
{

    public GameObject target;
    

	
	void Start ()
    {
        Vector3 targetposition = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        transform.LookAt(targetposition);
    }

}

	


