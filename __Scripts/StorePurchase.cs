using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StorePurchase : MonoBehaviour
{

    public GameObject music1;
    public GameObject music2;
    public GameObject music3;
    public Text cashText;
    public Text insufficient;
    void Start()
    {
        cashText.text = "" + Cash.getMoney();
    }
    public void ChoiceOne()
    {
        MusicScript.SetMusic(music1);
        Cash.addMoney(-10);
        if (Cash.getMoney() < 0) 
        { 
            Cash.addMoney(10);
            insufficient.text = "Insufficient Funds";
        }
        cashText.text = "" + Cash.getMoney();


    }
    public void ChoiceTwo()
    {
        MusicScript.SetMusic(music2);
        Cash.addMoney(-10);
        if (Cash.getMoney() < 0)
        {
            Cash.addMoney(10);
            insufficient.text = "Insufficient Funds";
        }
        cashText.text = "" + Cash.getMoney();

    }
    public void ChoiceThree()
    {
        MusicScript.SetMusic(music3);
        Cash.addMoney(-10);
        if (Cash.getMoney() < 0)
        {
            Cash.addMoney(10);
            insufficient.text = "Insufficient Funds";
        }
        cashText.text = "" + Cash.getMoney();

    }
    public void ChoiceFour()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        Cash.addMoney(-15);
        if (Cash.getMoney() < 0)
        {
            Cash.addMoney(15);
            insufficient.text = "Insufficient Funds";
        }
        cashText.text = "" + Cash.getMoney();
        SceneManager.LoadScene("QuizLevel1");


    }

    public void Exit()
    {
        gameObject.SetActive(false);
    }

}
