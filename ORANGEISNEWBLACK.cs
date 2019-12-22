using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORANGEISNEWBLACK : MonoBehaviour
{

    int RotationZ = -90;
    public GameObject closestYol;
    public GameObject Top;
    float hipo;
    float eskix;
    float eskiy;
    float pizzakenari;
    float aci;
    float yol;
    float tur;
    float ocx;
    float ocy;
    float eskiz;
    float deltaz;
    int yon;

    void Start()
    {
        eskix = Top.transform.position.x;
        eskiy = Top.transform.position.y;
        eskiz = Top.transform.position.z;
    }


    void FixedUpdate()
    {
        transform.position = Top.transform.position;
        float farkx = closestYol.transform.position.x - this.transform.position.x;
        float farky = closestYol.transform.position.y - this.transform.position.y;

        float sina = (Mathf.Abs(farky) / Mathf.Sqrt(farkx * farkx + farky * farky));

        float sonucacı = (-Mathf.Asin(sina) * 180 / Mathf.PI);





        if (this.transform.position.x - closestYol.transform.position.x > 0 & this.transform.position.y - closestYol.transform.position.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, -sonucacı + RotationZ);

        }

        if (this.transform.position.x - closestYol.transform.position.x < 0 & this.transform.position.y - closestYol.transform.position.y < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, -sonucacı + 180 + RotationZ);
        }

        if (this.transform.position.x - closestYol.transform.position.x < 0 & this.transform.position.y - closestYol.transform.position.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180 + sonucacı + RotationZ);
        }

        if (this.transform.position.x - closestYol.transform.position.x > 0 & this.transform.position.y - closestYol.transform.position.y < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, sonucacı + RotationZ);
        }


        ocx = Top.transform.position.x - eskix;
        ocy = Top.transform.position.y - eskiy;
        if (Top.transform.position.x < 0 && ocy > 0)
        {
            yon = 1;
        }
        else if (Top.transform.position.x < 0 && ocy < 0)
        {
            yon = -1;
        }
        else if (Top.transform.position.x > 0 && ocy < 0)
        {
            yon = 1;
        }
        if (Top.transform.position.x > 0 && ocy > 0)
        {
            yon = -1;
        }



        ocx = Mathf.Round(ocx * 100) / 100;

        ocy = Mathf.Round(ocy * 100) / 100;

        hipo = Mathf.Sqrt((ocx * ocx) + (ocy * ocy));

        eskix = Top.transform.position.x;
        eskiy = Top.transform.position.y;
        pizzakenari = (float)(hipo * (10 / 11.0f));
        aci = 2 * Mathf.Asin((pizzakenari / 2) / 50);
        yol = (aci * 15.7f / 18.0f);
        tur = yol * 360 / 31.4f;
        Top.transform.RotateAround(this.transform.forward, -tur * yon);

        deltaz = Top.transform.position.z - eskiz;
        eskiz = Top.transform.position.z;
        tur = deltaz / 31.4f;
        Top.transform.RotateAround(this.transform.right, tur * 8 / 5);

    }
}
