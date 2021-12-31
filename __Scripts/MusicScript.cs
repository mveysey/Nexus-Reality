using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public static GameObject musicPlaying;
    // Start is called before the first frame update
    public static void SetMusic(GameObject music)
    {
        if (musicPlaying != null)
        {
            musicPlaying.SetActive(false);
        }
        musicPlaying = music;
        PlayMusic();


    }

    // Update is called once per frame
    public static void PlayMusic()
    {
        if (musicPlaying.gameObject.CompareTag("Purchased"))
        {
            musicPlaying.SetActive(true);
            Instantiate(musicPlaying, new Vector3(0, 0, 0), Quaternion.identity);
            
        }
        
        

    }
}
