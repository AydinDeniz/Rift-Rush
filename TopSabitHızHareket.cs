using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopSabitHızHareket : MonoBehaviour
{
    Rigidbody fizik;
    Vector3 vec;
    void Start()
    {
    }

    void FixedUpdate()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + Depo.hiz);
    }
}