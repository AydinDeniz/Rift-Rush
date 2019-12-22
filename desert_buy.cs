using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desert_buy : MonoBehaviour
{

    public int objno;
    public Renderer rend1;
    public Renderer rend2;
    public GameObject explosion;
    private void OnMouseDown()
    {
        GetComponent<gembuyquestion>().create(gameObject);
    }

    public void Buy()
    {
        desert_depo.deserto[objno] = 1;


        rend1.enabled = true;
        rend2.enabled = true;
        Object.Destroy(gameObject);
        Instantiate(explosion, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z));


    }
}
