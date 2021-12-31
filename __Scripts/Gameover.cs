using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gameover : MonoBehaviour
{
    public void start()
    {
        SceneHistory.changeToPreviousLvl();
        print("hi");

    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        SceneHistory.changeToPreviousLvl();
    }
}
