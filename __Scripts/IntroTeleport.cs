using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroTeleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Teleport());
        
    }
    IEnumerator Teleport()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        yield return new WaitForSeconds(40);
        SceneManager.LoadScene("QuizLevel1");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
