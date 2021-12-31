using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowMoney2 : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Start()
    {
        text.text = "" + Cash.getMoney();
    }
    void Update()
    {
        text.text = "" + Cash.getMoney();
    }
}
