using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{
    public int targetCount;
    
    void Start()
    {
        targetCount = 0; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target") && gameObject.CompareTag("Arrow"))
        {
            other.gameObject.SetActive(false); 
            targetCount++;
            Cash.addMoney(1);
            
        }
    }
}
