using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gembuyquestion : MonoBehaviour
{
    public GameObject gem_public;
    public GameObject button;
    public bool button1 = false;
    public bool waited = false;
    public void Start()
    {
        
        StartCoroutine(Waiter());
    }

    public void create(GameObject gem)
    {
        
        GameObject new_button = Instantiate(button, transform.position, new Quaternion(0, 0, 0, 0));
        new_button.GetComponent<gembuyquestion>().gem_public = gem;
        new_button.GetComponent<gembuyquestion>().button1 = true;
        

    }
    private void OnMouseDown()
    {
        if (button1 == true)
        {
            GameObject.FindGameObjectWithTag("SoundController").GetComponent<Manager>().Playsound("buy_coll");
            gem_public.GetComponent<desert_buy>().Buy();
            
            Destroy(gameObject);
        }
    }
    private void LateUpdate()
    {
        if (button1 == true & waited==true)
        {
            
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(gameObject);
            }


        }
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(0.1f);
        waited = true;
    }

}