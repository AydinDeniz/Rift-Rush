using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelSecim : MonoBehaviour
{
    bool gem_created = false;

    public GameObject engel1;
    public float engel1_oranı;
    
    public GameObject engel2;
    public float engel2_oranı;
    
    public GameObject engel3;
    public float engel3_oranı;
    
    public GameObject engel4;
    public float engel4_oranı;
    
    public GameObject engel5;
    public float engel5_oranı;
    
    public GameObject engel6;
    public float engel6_oranı;
    
    public GameObject engel7;
    public float engel7_oranı;

    public GameObject[] gems;
    public int[] gem_chances;
    int olasilik;

    void Start ()
    {
        float oran = 100/(engel1_oranı + engel2_oranı + engel3_oranı + engel4_oranı + engel5_oranı + engel6_oranı + engel7_oranı);

        int gem_olasılık = Random.Range(1, 50000);
        olasilik = Random.Range(0, 100);

        if (olasilik <= engel1_oranı * oran)
        {
            Gem_check(gem_olasılık);
            if (gem_created == false)
            {
                Instantiate(engel1, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z));

            }
        }
        if (olasilik <= engel1_oranı * oran + engel2_oranı * oran & olasilik > engel1_oranı * oran)
        {
            Gem_check(gem_olasılık);
            if (gem_created == false)
            {
                Instantiate(engel2, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z));
            }
        }
        if (olasilik <= engel1_oranı * oran + engel2_oranı * oran + engel3_oranı * oran & olasilik > engel2_oranı * oran + engel1_oranı * oran)
        {
            Gem_check(gem_olasılık);
            if (gem_created == false)
            {
                Instantiate(engel3, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z));
            }
        }
        if (olasilik <= engel1_oranı * oran + engel2_oranı * oran + engel3_oranı * oran + engel4_oranı * oran & olasilik > engel1_oranı * oran + engel2_oranı * oran + engel3_oranı * oran)
        {
            Gem_check(gem_olasılık);
            if (gem_created == false)
            {
                Instantiate(engel4, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z));
            }
        }
        if (olasilik <= engel1_oranı * oran + engel2_oranı * oran + engel3_oranı * oran + engel4_oranı * oran + engel5_oranı * oran & olasilik > engel1_oranı * oran + engel2_oranı * oran + engel3_oranı * oran + engel4_oranı * oran)
        {
            Gem_check(gem_olasılık);
            if (gem_created == false)
            {
                Instantiate(engel5, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z));
            }
        }
        if (olasilik <= engel1_oranı * oran + engel2_oranı * oran + engel3_oranı * oran + engel4_oranı * oran + engel5_oranı * oran + engel6_oranı * oran & olasilik > engel1_oranı * oran + engel2_oranı * oran + engel3_oranı * oran + engel4_oranı * oran + engel5_oranı * oran)
        {
            Gem_check(gem_olasılık);
            if (gem_created == false)
            {
                Instantiate(engel6, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z));
            }
        }
        if (olasilik <= engel1_oranı * oran + engel2_oranı * oran + engel3_oranı * oran + engel4_oranı * oran + engel5_oranı * oran + engel6_oranı * oran + engel7_oranı * oran & olasilik > engel1_oranı * oran + engel2_oranı * oran + engel3_oranı * oran + engel4_oranı * oran + engel5_oranı * oran + engel6_oranı * oran)
        {
            Gem_check(gem_olasılık);
            if (gem_created == false)
            {
                Instantiate(engel7, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z));
            }
        }

        Destroy(gameObject);
        
    }
    void Gem_check(int gem_olasılık)
    {

        if (gem_olasılık <= gem_chances[0])
        {
            if (GameObject.FindGameObjectWithTag("Player").transform.position.z + 400 <= this.transform.position.z)
            {
                Instantiate(gems[0], new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z));
                Destroy(gameObject);
                gem_created = true;
            }
        }
        else if (gem_olasılık <= gem_chances[1])
        {
            if (GameObject.FindGameObjectWithTag("Player").transform.position.z + 400 <= this.transform.position.z)
            {
                Instantiate(gems[1], new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z));
                Destroy(gameObject);
                gem_created = true;

            }
        }
        else if (gem_olasılık <= gem_chances[2])
        {
            if (GameObject.FindGameObjectWithTag("Player").transform.position.z + 400 <= this.transform.position.z)
            {
                Instantiate(gems[2], new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z));
                Destroy(gameObject);
                gem_created = true;
            }
        }
        else if (gem_olasılık <= gem_chances[3])
        {
            if (GameObject.FindGameObjectWithTag("Player").transform.position.z + 400 <= this.transform.position.z)
            {
                Instantiate(gems[3], new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z));
                Destroy(gameObject);
                gem_created = true;
            }
        }
    }

}
