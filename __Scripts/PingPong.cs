using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    
        public GameObject ball;
        public GameObject newBall;
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                Instantiate(newBall, new Vector3(-0.17f, -0.7f, 3.1f), Quaternion.identity);
                gameObject.SetActive(false);
            }
        }
    }

