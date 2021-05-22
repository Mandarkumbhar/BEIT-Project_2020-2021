using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video : MonoBehaviour
{
    public GameObject Tv;
    void start()
    {
        
        
    }

    public void StartVideo()
    {
        Tv.GetComponent<UnityEngine.Video.VideoPlayer>().enabled = true;
    }

    public void StopVideo()
    {
        Tv.GetComponent<UnityEngine.Video.VideoPlayer>().enabled = false;
    }
}
