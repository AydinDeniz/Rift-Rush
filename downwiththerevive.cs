using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downwiththerevive : MonoBehaviour
{

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("engel"))
        {
            other.GetComponent<sink>().enabled = true;
            other.transform.gameObject.tag = "Finish";
        }

        if (other.gameObject.CompareTag("engelsecim"))
        {
            other.GetComponent<sink>().enabled = true;
            other.transform.gameObject.tag = "Finish";
        }

        if (other.gameObject.CompareTag("allahsizlar"))
        {
            other.GetComponent<sink>().enabled = true;
            other.transform.gameObject.tag = "Finish";
        }
    }
}