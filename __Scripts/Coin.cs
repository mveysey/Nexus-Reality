using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public int coinCount;
    public static int points;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        coinCount = 0;
        
    }

    public int getPoints()
    {
        return points;
    }


    private void OnTriggerEnter(Collider other)
    {
        //if the tag of the object is Pickup to make sure the walls 
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false); //to disable the game object and make it dissapear
            coinCount++;

        }
        if (coinCount == 10)
        {
            points = 10;
            text.text = "" + getPoints();
            Cash.addMoney(10);
            SceneManager.LoadScene("GameOver3");
        }

        


    }
}
