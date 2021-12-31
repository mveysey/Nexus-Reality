using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketPoints : MonoBehaviour
{
    private int points = 0;
    public Text text;

    void Start()
    {
       text.text = "" + displayPoints();
    }

    void Update()
    {
        text.text = "" + displayPoints();
    }
    public int displayPoints()
    {
        return points;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball") && gameObject.CompareTag("Basket"))
        {
            points++;
            Cash.addMoney(1);
        }
    }
}
