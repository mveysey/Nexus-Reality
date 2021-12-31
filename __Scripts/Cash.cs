using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cash : MonoBehaviour
{
    public static int money;

    // Start is called before the first frame update
    static void Start()
    {
        money = 0;
        
    }
    public static void addMoney(int cash)
    {

        money = money + cash;
    }

    public static int getMoney()
    {
        return money*100;
    }


   
}
