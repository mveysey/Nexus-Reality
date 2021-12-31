using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetStage : MonoBehaviour
{
    public static int level;

    // Start is called before the first frame update
    static void Start()
    {
        level = 0;

    }
    public static void addLevel(int stage)
    {

        level = level + stage;
    }

    public static int getLevel()
    {
        return level;
    }
}
