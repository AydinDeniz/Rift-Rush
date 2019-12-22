using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    public float xSpread;
    public float ySpread;
    public float zOffset;
    public GameObject center;
    public bool yeteraq = false;

    public float rotSpeed;


    float timer = 180;

    void FixedUpdate()
    {
       




        if (Input.GetMouseButton(0))
        {
            
            timer += -Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime;

            if (yeteraq == false)
            {
                timer = -1.57079028f;
            }

            float x = -Mathf.Cos(timer) * xSpread;
            float y = -Mathf.Sin(timer) * ySpread;
            Vector3 pos = new Vector3(x, y, this.transform.position.z);
            transform.position = pos + center.transform.position;

            

            yeteraq = true;







        }
    }
}
