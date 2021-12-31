using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowStage : MonoBehaviour
{
    public Text text;
    void Start()
    {
        text.text = "" + GetStage.getLevel();
    }
    void Update()
    {
        text.text = "" + GetStage.getLevel();
    }
}
