using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartbeat : MonoBehaviour
{
    public AudioSource heartSound;
    public AudioSource warSound;


    void Start()
    {
        StartCoroutine(SoundDelay());
        StartCoroutine(WarSoundsDelay());

    }

    IEnumerator SoundDelay()
    {
        yield return new WaitForSeconds(42f);
        heartSound.Play();
    }

    IEnumerator WarSoundsDelay()
    {
        yield return new WaitForSeconds(40f);
        warSound.Play();
    }
}
