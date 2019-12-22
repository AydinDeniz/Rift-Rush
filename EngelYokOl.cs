using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelYokOl : MonoBehaviour
{

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("engel"))
        {
            Destroy(other.gameObject);  //yok etme
        }

        if (other.gameObject.CompareTag("engelsecim"))
        {
            Destroy(other.gameObject);  //yok etme
        }

        if (other.gameObject.CompareTag("allahsizlar"))
        {
            Destroy(other.gameObject);  //yok etme
        }
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);  //yok etme
        }
    }


}



