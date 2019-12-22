using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionNext : MonoBehaviour {

    public bool hidden = true;
    GameObject center;
    public bool move = false;
    public int speed=35;
    public bool left;
    public Vector3 rotation = new Vector3(0, 0, 0);
    void Start()
    {
        center = GameObject.FindGameObjectWithTag("center_worlds");
    }

    public void next()
    {
        if(hidden==true)
        {
            
            move = true;

            hidden = false;
        }
        else
        {
            move = true;
            hidden = true;
        }
    }
    void Update()
    {
        if(move==true)
        {
            if (left == true)
            {
                transform.RotateAround(center.transform.position, Vector3.up, speed * Time.deltaTime);
            }
            else
            {
                transform.RotateAround(center.transform.position, Vector3.down, speed * Time.deltaTime);
            }

            if (this.transform.localPosition.z<-67.995f & hidden==false)
            {
                
                move = false;
            }
            else if(this.transform.localPosition.z > -48.005f & hidden == true)
            {
                Debug.Log(left);
                move = false;
                if(left==true)
                {
                    
                    Destroy(gameObject);
                }
                else
                {
                    
                    Destroy(gameObject);
                }
            }
        }
    }


}
