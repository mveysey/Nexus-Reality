using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizTeleport2 : MonoBehaviour
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
            
            

            
            if (gameObject.CompareTag("FutureHuman"))
            {
                SceneManager.LoadScene("QuizLevel3-futurehuman");
            }
             if (gameObject.CompareTag("FutureAnimal"))
            {
                SceneManager.LoadScene("QuizLevel3-futureanimal");
            }
             if (gameObject.CompareTag("FutureFood"))
            {
                SceneManager.LoadScene("QuizLevel3-futurefood");
            }
               
               if (gameObject.CompareTag("PastHuman"))
            {
                SceneManager.LoadScene("QuizLevel3-pasthuman");
            }
               if (gameObject.CompareTag("PastAnimal"))
            {
                SceneManager.LoadScene("QuizLevel3-pastanimal");
            }
               if (gameObject.CompareTag("PastFood"))
            {
                SceneManager.LoadScene("QuizLevel3-pastfood");
            }
               
               if (gameObject.CompareTag("PresentHuman"))
            {
                SceneManager.LoadScene("QuizLevel3-presenthuman");
            }
               if (gameObject.CompareTag("PresentAnimal"))
            {
                SceneManager.LoadScene("QuizLevel3-presentanimal");
            }
               if (gameObject.CompareTag("PresentFood"))
            {
                SceneManager.LoadScene("QuizLevel3-presentfood");
            }
               
               
               
               
               
               if (gameObject.CompareTag("FutureAnimalHot"))
            {
                SceneManager.LoadScene("Home6");
            }
            if (gameObject.CompareTag("FutureAnimalCold"))
            {
                SceneManager.LoadScene("Home15");
            }
            if (gameObject.CompareTag("FutureHumanHot"))
            {
                SceneManager.LoadScene("Home3");
            }
            if (gameObject.CompareTag("FutureHumanCold"))
            {
                SceneManager.LoadScene("Home12");
            }
            if (gameObject.CompareTag("FutureFoodCold"))
            {
                SceneManager.LoadScene("Home18");
            }
            if (gameObject.CompareTag("FutureFoodHot"))
            {
                SceneManager.LoadScene("Home9");
            }
             
             if (gameObject.CompareTag("PresentHumanCold"))
            {
                SceneManager.LoadScene("Home10");
            }   
            if (gameObject.CompareTag("PresentHumanHot"))
            {
                SceneManager.LoadScene("Home1");
            }
            if (gameObject.CompareTag("PresentAnimalCold"))
            {
                SceneManager.LoadScene("Home13");
            }
            if (gameObject.CompareTag("PresentAnimalHot"))
            {
                SceneManager.LoadScene("Home4");
            }
            if (gameObject.CompareTag("PresentFoodCold"))
            {
                SceneManager.LoadScene("Home16");
            }
            if (gameObject.CompareTag("PresentFoodHot"))
            {
                SceneManager.LoadScene("Home7");
            }

            if (gameObject.CompareTag("PastAnimalCold"))
            {
                SceneManager.LoadScene("Home14");
            }
            if (gameObject.CompareTag("PastAnimalHot"))
            {
                SceneManager.LoadScene("Home5");
            }
            if (gameObject.CompareTag("PastHumanHot"))
            {
                SceneManager.LoadScene("Home2");
            }
            if (gameObject.CompareTag("PastHumanCold"))
            {
                SceneManager.LoadScene("Home11");
            }
            if (gameObject.CompareTag("PastFoodHot"))
            {
                SceneManager.LoadScene("Home8");
            }
            if (gameObject.CompareTag("PastFoodCold"))
            {
                SceneManager.LoadScene("Home17");
            }
        }
    }

}
