using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Covid : MonoBehaviour
{
    public GameObject[] drawers = new GameObject[18];
    System.Random random = new System.Random();
    public GameObject drawer1;
    public GameObject drawer2;
    public GameObject drawer3;
    public GameObject drawer4;
    public GameObject drawer5;
    public static int counter;
    public static int points;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        drawer1= Instantiate(drawers[random.Next(0, 18)], new Vector3(3.76f, -7.23f, 1.98f), Quaternion.identity);
        drawer2= Instantiate(drawers[random.Next(0, 18)], new Vector3(3.76f, -7.23f, 1.33f), Quaternion.identity);
        drawer3= Instantiate(drawers[random.Next(0, 18)], new Vector3(3.76f, -7.23f, 0.67f), Quaternion.identity);
        drawer4= Instantiate(drawers[random.Next(0, 18)], new Vector3(3.76f, -7.23f, 0.025f), Quaternion.identity);
        drawer5= Instantiate(drawers[random.Next(0, 18)], new Vector3(3.76f, -7.23f, -0.714f), Quaternion.identity);
    }
    void NewDrawers()
    {
        drawer1 = drawers[random.Next(0, 18)];
        drawer2 = drawers[random.Next(0, 18)];
        drawer3 = drawers[random.Next(0, 18)];
        drawer4 = drawers[random.Next(0, 18)];
        drawer5 = drawers[random.Next(0, 18)];
        Instantiate(drawer1, new Vector3(3.76f, -7.23f, 1.98f), Quaternion.identity);
        Instantiate(drawer2, new Vector3(3.76f, -7.23f, 1.33f), Quaternion.identity);
        Instantiate(drawer3, new Vector3(3.76f, -7.23f, 0.67f), Quaternion.identity);
        Instantiate(drawer4, new Vector3(3.76f, -7.23f, 0.025f), Quaternion.identity);
        Instantiate(drawer5, new Vector3(3.76f, -7.23f, -0.714f), Quaternion.identity);

    }
    public static void AddPoints()
    {
        counter++;
        points++;
        Cash.addMoney(1);

    }
    public int getPoints()
    {
        return points;
    }


    // Update is called once per frame
    void Update()
    {
        if (counter % 5 == 0 && counter != 0)
        {
            NewDrawers();
            counter = 0;
           
        }

            text.text = "" + getPoints();
        

    }
}
