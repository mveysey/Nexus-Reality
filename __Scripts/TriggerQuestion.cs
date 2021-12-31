using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriggerQuestion : MonoBehaviour
{
    public GameObject question;    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(question, new Vector3(21.39f, 0.558f, 2.67f), Quaternion.identity);
        }
     


    }
}
