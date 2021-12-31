using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Scene1"))
            {
                SceneManager.LoadScene("Scene1");
            }
            if (gameObject.CompareTag("Home1"))
            {
                SceneManager.LoadScene("Home1");
            }
            if (gameObject.CompareTag("Scene2"))
            {
                SceneManager.LoadScene("Scene2");
            }
            if (gameObject.CompareTag("Home2"))
            {
                SceneManager.LoadScene("Home2");
            }
            if (gameObject.CompareTag("Scene3"))
            {
                SceneManager.LoadScene("Scene3");
            }
            if (gameObject.CompareTag("Home3"))
            {
                SceneManager.LoadScene("Home3");
            }
            if (gameObject.CompareTag("Scene4"))
            {
                SceneManager.LoadScene("Scene4");
            }
            if (gameObject.CompareTag("Home4"))
            {
                SceneManager.LoadScene("Home4");
            }
            if (gameObject.CompareTag("Scene5"))
            {
                SceneManager.LoadScene("Scene5");
            }
            if (gameObject.CompareTag("Home5"))
            {
                SceneManager.LoadScene("Home5");
            }
            if (gameObject.CompareTag("Scene6"))
            {
                SceneManager.LoadScene("Scene6");
            }
            if (gameObject.CompareTag("Home6"))
            {
                SceneManager.LoadScene("Home6");
            }
            if (gameObject.CompareTag("Scene7"))
            {
                SceneManager.LoadScene("Scene7");
            }
            if (gameObject.CompareTag("Home7"))
            {
                SceneManager.LoadScene("Home7");
            }
            if (gameObject.CompareTag("Scene8"))
            {
                SceneManager.LoadScene("Scene8");
            }
            if (gameObject.CompareTag("Home8"))
            {
                SceneManager.LoadScene("Home8");
            }
            if (gameObject.CompareTag("Scene9"))
            {
                SceneManager.LoadScene("Scene9");
            }
            if (gameObject.CompareTag("Home9"))
            {
                SceneManager.LoadScene("Home9");
            }
            if (gameObject.CompareTag("Scene10"))
            {
                SceneManager.LoadScene("Scene10");
            }
            if (gameObject.CompareTag("Home10"))
            {
                SceneManager.LoadScene("Home10");
            }
            if (gameObject.CompareTag("Scene11"))
            {
                SceneManager.LoadScene("Scene11");
            }
            if (gameObject.CompareTag("Home11"))
            {
                SceneManager.LoadScene("Home11");
            }
            if (gameObject.CompareTag("Scene12"))
            {
                SceneManager.LoadScene("Scene12");
            }
            if (gameObject.CompareTag("Home12"))
            {
                SceneManager.LoadScene("Home12");
            }
            if (gameObject.CompareTag("Scene13"))
            {
                SceneManager.LoadScene("Scene13");
            }
            if (gameObject.CompareTag("Home13"))
            {
                SceneManager.LoadScene("Home13");
            }
            if (gameObject.CompareTag("Scene14"))
            {
                SceneManager.LoadScene("Scene14");
            }
            if (gameObject.CompareTag("Home14"))
            {
                SceneManager.LoadScene("Home14");
            }
            if (gameObject.CompareTag("Scene15"))
            {
                SceneManager.LoadScene("Scene15");
            }
            if (gameObject.CompareTag("Home15"))
            {
                SceneManager.LoadScene("Home15");
            }
            if (gameObject.CompareTag("Scene16"))
            {
                SceneManager.LoadScene("Scene16");
            }
            if (gameObject.CompareTag("Home16"))
            {
                SceneManager.LoadScene("Home16");
            }
            if (gameObject.CompareTag("Scene17"))
            {
                SceneManager.LoadScene("Scene17");
            }
            if (gameObject.CompareTag("Home17"))
            {
                SceneManager.LoadScene("Home17");
            }
            if (gameObject.CompareTag("Scene18"))
            {
                SceneManager.LoadScene("Scene18");
            }
            if (gameObject.CompareTag("Home18"))
            {
                SceneManager.LoadScene("Home18");
            }
        }
    }

}
