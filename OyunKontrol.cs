using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public float baslangicbekleme;
    public float dongubekleme;
    public GameObject engel1;
    public GameObject Yol;
    public GameObject Top;
    public GameObject PortalNoktasi;
    bool kontrol=true;
    public int min=7;
    public int max=14;
    public int summonmesafe = 1600;

    void Start ()
    {
        StartCoroutine(olustur());
    }

    void Update()
    {

    }

    IEnumerator olustur()
    {
        float konumz = -900;
        float Portalz = PortalNoktasi.transform.position.z;

        while (kontrol)
        {


            float Topz = Top.transform.position.z;

            if (konumz - Topz <= summonmesafe)
            {
                konumz = konumz + Random.Range(80, 100);
            }
            else if (konumz - Topz > summonmesafe)
            {
                    yield return new WaitForSeconds(dongubekleme);
                konumz = konumz + Random.Range(80, 100);

            }

            if(Portalz-konumz < 150)
            {
                break;
            }

                int t = Random.Range(min, max);

                {
                    for (int i = 0; i <= t; i++)
                    {
                        int degree = Random.Range(0, 359);
                        float mutlakx = Mathf.Sin(degree) * 50;
                        float mutlaky = Mathf.Sqrt(2500 - mutlakx * mutlakx);

                        if (degree < 90 & degree >= 0)
                        {
                            Instantiate(engel1, new Vector3(-mutlakx, mutlaky, konumz), Quaternion.Euler(0, 0, 0));
                        }

                        if (degree < 180 & degree >= 90)
                        {
                            Instantiate(engel1, new Vector3(-mutlakx, -mutlaky, konumz), Quaternion.Euler(0, 0, 0));
                        }

                        if (degree < 270 & degree >= 180)
                        {
                            Instantiate(engel1, new Vector3(mutlakx, -mutlaky, konumz), Quaternion.Euler(0, 0, 0));
                        }

                        if (degree < 360 & degree >= 270)
                        {
                            Instantiate(engel1, new Vector3(mutlakx, mutlaky, konumz), Quaternion.Euler(0, 0, 0));
                        }
                    }
                }

            
        }
    }
}
