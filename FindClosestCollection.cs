using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindClosestCollection : MonoBehaviour
{
    public float RotationZ = 0;
    public float RotationY = 0;
    public float RotationX = 0;



    void Start()
    {
        
        GameObject closestYol = GameObject.FindGameObjectWithTag("collection");
        if (closestYol.name != "chess_collection(Clone)")
        {

    

            float farkx = closestYol.transform.position.x - this.transform.position.x;
            float farky = closestYol.transform.position.y - this.transform.position.y;

            float sina = (Mathf.Abs(farky) / Mathf.Sqrt(farkx * farkx + farky * farky));

            float sonucacı = (-Mathf.Asin(sina) * 180 / Mathf.PI);






            if (this.transform.position.x - closestYol.transform.position.x > 0 & this.transform.position.y - closestYol.transform.position.y > 0)
            {
                transform.Rotate(RotationX, RotationY, -sonucacı + RotationZ);

            }

            if (this.transform.position.x - closestYol.transform.position.x < 0 & this.transform.position.y - closestYol.transform.position.y < 0)
            {
                transform.Rotate(RotationX, RotationY, -sonucacı + 180 + RotationZ);
            }

            if (this.transform.position.x - closestYol.transform.position.x < 0 & this.transform.position.y - closestYol.transform.position.y > 0)
            {
                transform.Rotate(RotationX, RotationY, 180 + sonucacı + RotationZ);
            }

            if (this.transform.position.x - closestYol.transform.position.x > 0 & this.transform.position.y - closestYol.transform.position.y < 0)
            {
                transform.Rotate(RotationX, RotationY, sonucacı + RotationZ);
            }


        }








    }

}
