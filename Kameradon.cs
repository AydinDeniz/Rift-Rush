using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kameradon : MonoBehaviour {

    
    public bool don = false;
    public int yon = 1;
    public int ayar;
    
    void OnMouseDown()
    {
        don = true;
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.5f);
        yield return new WaitUntil(()=> Camera.main.transform.eulerAngles.y+1000<=ayar+1000);
        don = false;
    }


    void FixedUpdate ()
    {
        if (don==true)
        {
            Camera.main.transform.eulerAngles=new Vector3(Camera.main.transform.eulerAngles.x,Camera.main.transform.eulerAngles.y+ yon,Camera.main.transform.eulerAngles.z);
            Debug.Log(Camera.main.transform.eulerAngles.y);
        }

    }
	
	
}
