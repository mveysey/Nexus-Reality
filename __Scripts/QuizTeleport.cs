using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizTeleport : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("PastDoor"))
            {
                SceneManager.LoadScene("QuizLevel2-past");
            }
            if (gameObject.CompareTag("PresentDoor"))
            {
                SceneManager.LoadScene("QuizLevel2-present");
            }
            if (gameObject.CompareTag("FutureDoor"))
            {
                SceneManager.LoadScene("QuizLevel2-future");
            }
        }
    }

}
