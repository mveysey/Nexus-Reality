using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Covid2 : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(gameObject.tag))
        {
            gameObject.SetActive(false);
            other.gameObject.SetActive(false);
            Covid.AddPoints();

        }
    }
}
