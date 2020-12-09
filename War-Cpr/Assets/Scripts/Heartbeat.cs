using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartbeat : MonoBehaviour
{
    public AudioSource heartSound;
    public AudioSource warSound;
    public AudioSource stressSounds;

    void Start()
    {
        StartCoroutine(SoundDelay());
        StartCoroutine(WarSoundsDelay());
        StartCoroutine(StressSoundsDelay());


    }

    IEnumerator SoundDelay()
    {
        yield return new WaitForSeconds(42f);
        heartSound.Play();
    }

    IEnumerator WarSoundsDelay()
    {
        yield return new WaitForSeconds(42f);
        warSound.Play();
    }
    IEnumerator StressSoundsDelay()
    {
        yield return new WaitForSeconds(38f);
        stressSounds.Play();
    }
}
