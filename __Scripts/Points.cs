using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    private static int points = 0;
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

    public static void addthePoints()
    {
  
            points++;
        Cash.addMoney(1);

       
    }
}
