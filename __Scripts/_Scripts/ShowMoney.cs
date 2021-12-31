using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShowMoney : MonoBehaviour
{
    public Text text;
    void Start()
    {
        text.text = "$" + Cash.getMoney();
    }
    void Update()
    {
        text.text = "$" + Cash.getMoney();
    }
}
