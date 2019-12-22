using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sink : MonoBehaviour
{
    public bool active = false;
    public float speed = 50;
    public float add = 0;
    void Update()
    {
        speed = 150 / Depo.hiz;

        if (active == true)
        {
            add += Time.deltaTime;
            // Move our position a step closer to the target.
            float step = speed * Time.deltaTime * add; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, transform.position.z), step);
        }
        if (add > 2f)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}