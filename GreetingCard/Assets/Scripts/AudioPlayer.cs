using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource audio;

    public void audioPlay()
    {
        audio.Play();
    }
    public void audioStop()
    {
        audio.Stop();
    }

}
