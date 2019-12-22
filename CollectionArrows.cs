using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionArrows : MonoBehaviour {

    public bool active = true;
    GameObject[] worlds;
    public GameObject other_arrow;
    public bool left;
    void OnMouseDown()
    {
        
        if (active == true)
        {
            GameObject soundcontroler = GameObject.FindGameObjectWithTag("SoundController");
            soundcontroler.GetComponent<Manager>().Playsound("arrow");
            worlds = GameObject.FindGameObjectsWithTag("collection");
            foreach (GameObject world in worlds)
            {
                if (left == true)
                {
                    Debug.Log("eben");
                    world.GetComponent<CollectionNext>().left = true;
                    world.GetComponent<CollectionNext>().next();
                    GameObject.FindGameObjectWithTag("center_worlds").GetComponent<WorldManager>().spawn_world(true);
                }
                else
                {
                    Debug.Log("eben");
                    world.GetComponent<CollectionNext>().left = false;
                    world.GetComponent<CollectionNext>().next();
                    GameObject.FindGameObjectWithTag("center_worlds").GetComponent<WorldManager>().spawn_world(false);
                }
            }
            active = false;
            other_arrow.GetComponent<CollectionArrows>().active = false;
            StartCoroutine(other_arrow.GetComponent<CollectionArrows>().waiter());
            StartCoroutine(waiter());
        }
    }
    public IEnumerator waiter()
    {
        yield return new WaitForSeconds(1.25f);

        active = true;
    }
}
