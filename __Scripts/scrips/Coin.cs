﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if the tag of the object is Pickup to make sure the walls 
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false); //to disable the game object and make it dissapear

        }



    }
}
