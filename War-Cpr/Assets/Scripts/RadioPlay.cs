using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioPlay : MonoBehaviour
{
    public AudioSource radioSound;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SoundDelay());
    }


    IEnumerator SoundDelay()
    {
        yield return new WaitForSeconds(38f);
        radioSound.Play();
    }

}
