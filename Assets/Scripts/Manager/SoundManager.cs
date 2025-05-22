using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioSource audioSource;
    void Awake()
    {
        
    }
    public void PlaySE(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
