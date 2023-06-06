using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClick : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip clickSound;

    public void ClickSound()
    {
        audioSource.PlayOneShot(clickSound);
        Debug.Log("U play sound");
    }
}
