using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketball : MonoBehaviour
{
    public GameObject ball;
    public GameObject newBall;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Instantiate(newBall,new Vector3(3.304f, -18.5f, -1.291f), Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}
