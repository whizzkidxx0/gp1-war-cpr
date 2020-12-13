using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioPlay : MonoBehaviour
{
    public AudioSource radioSound;
    public AudioSource alarmSound;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SoundDelay());
        StartCoroutine(AlarmDelay());

    }


    IEnumerator SoundDelay()
    {
        yield return new WaitForSeconds(35f);
        radioSound.Play();
    }

    IEnumerator AlarmDelay()
    {
        yield return new WaitForSeconds(40f);
        alarmSound.Play();
    }

}
