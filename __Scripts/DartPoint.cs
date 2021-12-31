using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DartPoint : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Target") && other.gameObject.CompareTag("Arrow"))
        {
            Points.addthePoints();
        }
       
    }
}
