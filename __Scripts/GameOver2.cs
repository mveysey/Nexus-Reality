using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        print("hi");
        StartCoroutine(Wait());

    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        SceneHistory.changeToPreviousLvl();
    }
}
