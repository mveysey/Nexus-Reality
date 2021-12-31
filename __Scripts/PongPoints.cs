using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongPoints : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Cup") && other.gameObject.CompareTag("Ball"))
        {
            Points.addthePoints();
        }

    }
}
