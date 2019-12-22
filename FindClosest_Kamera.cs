using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindClosest_Kamera : MonoBehaviour {

    public float RotationZ = 0;
    public bool yeteraq = false;




    void Update()
    {
        float distanceToClosestYol = Mathf.Infinity;
        Yol closestYol = null;
        Yol[] allYols = GameObject.FindObjectsOfType<Yol>();

        foreach (Yol currentYol in allYols)
        {
            float distanceToYol = (currentYol.transform.position - this.transform.position).sqrMagnitude;
            if (distanceToYol < distanceToClosestYol)
            {
                distanceToClosestYol = distanceToYol;
                closestYol = currentYol;
            }
        }




        float farkx = closestYol.transform.position.x - this.transform.position.x;
        float farky = closestYol.transform.position.y - this.transform.position.y;

        float sina = (Mathf.Abs(farky) / Mathf.Sqrt(farkx * farkx + farky * farky));

        float sonucacı = (-Mathf.Asin(sina) * 180 / Mathf.PI);

        //Vector3 dönülüceknokta = new Vector3(closestYol.transform.position.x,
        //                                closestYol.transform.position.y,
        //                                this.transform.position.z);
        //this.transform.LookAt(dönülüceknokta);

        //if (this.transform.position.x > closestYol.transform.position.x)
        //{
        //    transform.Rotate(0, 90, -90);
        //}

        //if (this.transform.position.x < closestYol.transform.position.x)
        //{
        //    transform.Rotate(0, -90, +90);
        //}
        //if(yeteraq==false)
        //{
        //    transform.Rotate(0, 0, 0);
        //    yeteraq = true;
        //}





        if (this.transform.position.x - closestYol.transform.position.x > 0 & this.transform.position.y - closestYol.transform.position.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, -sonucacı + RotationZ);

        }

        if (this.transform.position.x - closestYol.transform.position.x < 0 & this.transform.position.y - closestYol.transform.position.y < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, -sonucacı +180+ RotationZ);
        }

        if (this.transform.position.x - closestYol.transform.position.x < 0 & this.transform.position.y - closestYol.transform.position.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180+sonucacı + RotationZ);
        }

        if (this.transform.position.x - closestYol.transform.position.x > 0 & this.transform.position.y - closestYol.transform.position.y < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, sonucacı + RotationZ);
        }











    }

}
