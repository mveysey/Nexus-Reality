using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MusicScript.SetMusic(gameObject);
        
    }

}
